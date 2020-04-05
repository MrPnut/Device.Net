﻿using System;
using System.Threading.Tasks;

namespace Device.Net
{
    public interface IDeviceListener : IDisposable
    {
        event EventHandler<DeviceEventArgs> DeviceDisconnected;
        event EventHandler<DeviceEventArgs> DeviceInitialized;

        Task CheckForDevicesAsync();
        void Start();
#pragma warning disable CA1716 // Identifiers should not match keywords
        void Stop();
#pragma warning restore CA1716 // Identifiers should not match keywords
    }
}