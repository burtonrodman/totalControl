using System;
using System.Collections.Generic;
using totalControl.Core.Device;

namespace totalControl.Core
{
    public interface IDeviceLocator : IDisposable
    {
        IEnumerable<IVolumeTarget> FindVolumeOutTargetsBySubstring(string substring);
        IEnumerable<IVolumeTarget> FindVolumeInTargetsBySubstring(string substring);
    }
}
