﻿using Entities.DomainInterfaces.Live;

namespace ApplicationLogic.Interfaces;

public interface IDataStreamReadModel
{
    public void BeginStreaming();
}