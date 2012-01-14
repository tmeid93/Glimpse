﻿using System.Collections.Generic;
using Glimpse.Core2.Framework;

namespace Glimpse.Core2.Extensibility
{
    //TODO: Clean this up
    public interface IGlimpseRuntime
    {
        ITabContext TabContext { get; }
        string Version { get; }
        void BeginRequest();
        void EndRequest();
        void ExecuteResource(string resourceName);
        void ExecuteResource(string resourceName, IDictionary<string, string> parameters);
        void ExecuteTabs();
        void ExecuteTabs(LifeCycleSupport support);
        bool Initialize();
        void UpdateConfiguration(GlimpseConfiguration configuration);
        bool IsInitialized { get; }
    }
}