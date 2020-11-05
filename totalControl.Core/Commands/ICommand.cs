using totalControl.Core.Definition;
using totalControl.Core.Profile;

namespace totalControl.Core.Commands
{
    public interface ICommand
    {
        void Initialize(Control control, ControlGroup controlGroup, MidiController midiController, ILogger logger, IDeviceLocator deviceLocator);
        bool ProcessEvent(int value);
        void ExecuteCommand();
    }
}
