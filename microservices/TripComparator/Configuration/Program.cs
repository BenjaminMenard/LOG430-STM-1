using Ambassador;
using Ambassador.Controllers;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Usecases;
using Entities.DomainInterfaces;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using MqContracts;
using Polly;
using RabbitMQ.Client;
using TripComparator.Controllers;
using TripComparator.External;
using HostInfo = TripComparator.External.HostInfo;

namespace Configuration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Todo tactique disponibilité retry
            Policy.Handle<Exception>().RetryForever().Execute(() =>
            {
                var builder = WebApplication.CreateBuilder(args);

                ConfigureServices(builder.Services);

                var app = builder.Build();

                app.UseSwagger();
                
                app.UseSwaggerUI();

                app.UseHttpsRedirection();

                app.UseCors(
                    options =>
                    {
                        options.AllowAnyOrigin();
                        options.AllowAnyHeader();
                        options.AllowAnyMethod();
                    }
                );

                app.UseAuthorization();

                app.MapControllers();

                app.Run();
            });
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            ConfigureMassTransit(services).Wait();

            services.AddControllers().PartManager.ApplicationParts.Add(new AssemblyPart(typeof(DebugController).Assembly));

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();

            services.AddSingleton<IHostInfo, HostInfo>();
            
            services.AddScoped<CompareTimes>();
            
            services.AddScoped<IRouteTimeProvider, RouteTimeProviderClient>();
            
            services.AddScoped<IDataStreamWriteModel, MassTransitRabbitMqClient>();
            
            services.AddScoped<IBusInfoProvider, StmClient>();
        }

        private static async Task ConfigureMassTransit(IServiceCollection services)
        {
            var mq = (await RestController.GetAddress(HostInfo.MqServiceName, LoadBalancingMode.RoundRobin)).FirstOrDefault();

            var reformattedAddress = $"rabbitmq{mq!.Address[4..]}";

            const string baseQueueName = "time_comparison.node_controller-to-any.query";

            var uniqueQueueName = $"{baseQueueName}.{Guid.NewGuid()}";

            services.AddMassTransit(x =>
            {
                x.AddConsumer<TripComparatorMqController>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(reformattedAddress);

                    cfg.Message<BusPositionUpdated>(topologyConfigurator => topologyConfigurator.SetEntityName("bus_position_updated"));
                    cfg.Message<CoordinateMessage>(topologyConfigurator => topologyConfigurator.SetEntityName("coordinate_message"));

                    cfg.ReceiveEndpoint(uniqueQueueName, endpoint =>
                    {
                        endpoint.ConfigureConsumeTopology = false;

                        endpoint.Bind<CoordinateMessage>(binding =>
                        {
                            binding.ExchangeType = ExchangeType.Topic;
                            binding.RoutingKey = "trip_comparison.query";
                        });

                        endpoint.ConfigureConsumer<TripComparatorMqController>(context);
                    });

                    cfg.Publish<BusPositionUpdated>(p => p.ExchangeType = ExchangeType.Topic);
                });
            });
        }
    }
}