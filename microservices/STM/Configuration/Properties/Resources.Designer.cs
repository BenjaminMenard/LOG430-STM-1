﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configuration.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Configuration.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to agency_id,agency_name,agency_url,agency_timezone,agency_lang,agency_phone,agency_fare_url
        ///STM,&quot;Société de transport de Montréal&quot;,http://www.stm.info,America/Montreal,fr,,http://www.stm.info/fr/infos/titres-et-tarifs
        ///.
        /// </summary>
        internal static string agency {
            get {
                return ResourceManager.GetString("agency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to service_id,monday,tuesday,wednesday,thursday,friday,saturday,sunday,start_date,end_date
        ///23J-H50J000S-82-S,1,1,1,1,1,0,0,20230109,20230324
        ///23J-H50J000S-82-SV,0,0,0,0,1,0,0,20230109,20230324
        ///23J-H54J000S-80-S,1,1,1,1,1,0,0,20230109,20230324
        ///23J-H55J000S-80-S,1,1,1,1,1,0,0,20230109,20230324
        ///23J-H55J000S-80-SV,0,0,0,0,1,0,0,20230109,20230324
        ///23J-H56J000S-82-S,1,1,1,1,1,0,0,20230109,20230324
        ///23J-H56J000S-82-SV,0,0,0,0,1,0,0,20230109,20230324
        ///23J-H57J000S-81-S,1,1,1,1,1,0,0,20230109,20230324
        ///23J-H58J000S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string calendar {
            get {
                return ResourceManager.GetString("calendar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to service_id,date,exception_type
        ///23J-H50J000S-82-S,20230227,2
        ///23J-H50J000S-82-S,20230228,2
        ///23J-H50J000S-82-S,20230301,2
        ///23J-H50J000S-82-S,20230302,2
        ///23J-H50J000S-82-S,20230303,2
        ///23J-H50J000S-82-SV,20230303,2
        ///23J-H50J000A-05-A,20230304,2
        ///23J-H50J000I-04-I,20230305,2
        ///23M-H50M000S-80-S,20230407,2
        ///23M-H50M000S-80-SV,20230407,2
        ///23M-H50M000S-80-S,20230410,2
        ///23M-H50M000S-80-S,20230522,2
        ///23J-H54J000S-80-S,20230227,2
        ///23J-H54J000S-80-S,20230228,2
        ///23J-H54J000S-80-S,20230301,2
        ///23J-H54J000S-80-S,20230302,2 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string calendar_dates {
            get {
                return ResourceManager.GetString("calendar_dates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fare_id,price,currency_type,payment_method,transfers,transfer_duration
        ///13S_747,11.00,CAD,0,,7200
        ///13S_REG,3.50,CAD,0,,7200
        ///.
        /// </summary>
        internal static string fare_attributes {
            get {
                return ResourceManager.GetString("fare_attributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fare_id,route_id,origin_id,destination_id,contains_id
        ///13S_REG,1,,,
        ///13S_REG,2,,,
        ///13S_REG,4,,,
        ///13S_REG,5,,,
        ///13S_REG,10,,,
        ///13S_REG,11,,,
        ///13S_REG,12,,,
        ///13S_REG,13,,,
        ///13S_REG,14,,,
        ///13S_REG,15,,,
        ///13S_REG,16,,,
        ///13S_REG,17,,,
        ///13S_REG,18,,,
        ///13S_REG,19,,,
        ///13S_REG,21,,,
        ///13S_REG,22,,,
        ///13S_REG,24,,,
        ///13S_REG,25,,,
        ///13S_REG,26,,,
        ///13S_REG,27,,,
        ///13S_REG,28,,,
        ///13S_REG,29,,,
        ///13S_REG,30,,,
        ///13S_REG,31,,,
        ///13S_REG,32,,,
        ///13S_REG,33,,,
        ///13S_REG,34,,,
        ///13S_REG,35,,,
        ///13S_REG,36,,,
        ///13S_REG,37,,,
        ///13S_REG,39, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string fare_rules {
            get {
                return ResourceManager.GetString("fare_rules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to feed_publisher_name,feed_publisher_url,feed_lang,feed_start_date,feed_end_date
        ///&quot;Société de transport de Montréal&quot;,http://www.stm.info,fr,20230109,20230618
        ///.
        /// </summary>
        internal static string feed_info {
            get {
                return ResourceManager.GetString("feed_info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to route_id,agency_id,route_short_name,route_long_name,route_type,route_url,route_color,route_text_color
        ///1,STM,1,Verte,1,http://www.stm.info/fr/infos/reseaux/metro/verte,00B300,000000
        ///2,STM,2,Orange,1,http://www.stm.info/fr/infos/reseaux/metro/orange,D95700,000000
        ///4,STM,4,Jaune,1,http://www.stm.info/fr/infos/reseaux/metro/jaune,FFD900,000000
        ///5,STM,5,Bleue,1,http://www.stm.info/fr/infos/reseaux/metro/bleue,0095E6,000000
        ///10,STM,10,De Lorimier,3,http://www.stm.info/fr/infos/reseaux/bus,009EE0,
        ///11,STM,11,Par [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string routes {
            get {
                return ResourceManager.GetString("routes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to shape_id,shape_pt_lat,shape_pt_lon,shape_pt_sequence
        ///11071,45.446466,-73.603118,10001
        ///11071,45.451158,-73.593242,10002
        ///11071,45.457010,-73.581691,20002
        ///11071,45.459441,-73.572021,30002
        ///11071,45.461894,-73.567074,40002
        ///11071,45.471063,-73.566267,50002
        ///11071,45.478465,-73.569336,60002
        ///11071,45.482509,-73.580180,70002
        ///11071,45.490068,-73.585812,80002
        ///11071,45.495570,-73.579310,90002
        ///11071,45.500879,-73.574715,100002
        ///11071,45.504064,-73.571586,110002
        ///11071,45.508220,-73.568433,120002
        ///11071,45.5110 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string shapes {
            get {
                return ResourceManager.GetString("shapes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] stop_times {
            get {
                object obj = ResourceManager.GetObject("stop_times", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to stop_id,stop_code,stop_name,stop_lat,stop_lon,stop_url,location_type,parent_station,wheelchair_boarding
        ///STATION_M118,10118,STATION ANGRIGNON,45.446466,-73.603118,,1,,1
        ///43,10118,Station Angrignon,45.446466,-73.603118,http://www.stm.info/fr/infos/reseaux/metro/angrignon,0,STATION_M118,1
        ///43-01,10118,Station Angrignon,45.446319,-73.603835,,2,STATION_M118,1
        ///STATION_M120,10120,STATION MONK,45.451158,-73.593242,,1,,2
        ///42,10120,Station Monk,45.451158,-73.593242,http://www.stm.info/fr/infos/reseaux/metro/monk,0, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string stops {
            get {
                return ResourceManager.GetString("stops", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to route_id,service_id,trip_id,trip_headsign,direction_id,shape_id,wheelchair_accessible,note_fr,note_en
        ///2,23J-GLOBAUX-22-S,263071713,STATION CÔTE-VERTU,1,20236,1,,
        ///2,23J-GLOBAUX-22-S,263071715,STATION MONTMORENCY,0,20237,1,,
        ///2,23J-GLOBAUX-22-S,263071720,STATION MONTMORENCY,0,20237,1,,
        ///2,23J-GLOBAUX-22-S,263071722,STATION CÔTE-VERTU,1,20238,1,,
        ///2,23J-GLOBAUX-22-S,263071727,STATION MONTMORENCY,0,20237,1,,
        ///2,23J-GLOBAUX-22-S,263071731,STATION CÔTE-VERTU,1,20236,1,,
        ///2,23J-GLOBAUX-22-S,263071736,STATION CÔT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trips {
            get {
                return ResourceManager.GetString("trips", resourceCulture);
            }
        }
    }
}
