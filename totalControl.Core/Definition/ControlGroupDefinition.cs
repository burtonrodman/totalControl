using System.Collections.Generic;

namespace totalControl.Core.Definition
{
    public class ControlGroupDefinition
    {
        public string Name { get; set; }
        public IEnumerable<string> ControlNames { get; set; }
    }
}
