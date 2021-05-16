using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ScpDoorDestroyer
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Can SCP-173 break doors?")]
        public bool scp173 { get; set; } = true;


        [Description("Can SCP-049 break doors?")]
        public bool scp049 { get; set; } = true;

        [Description("Can SCP-096 break doors?")]
        public bool scp096 { get; set; } = true;

        [Description("Can SCP-939-53 break doors?")]
        public bool scp93953 { get; set; } = true;


        [Description("Can SCP-939-89 break doors?")]
        public bool scp93989 { get; set; } = true;

        [Description("Can SCP-049-2 break doors?")]
        public bool scp0492 { get; set; } = true;

        [Description("Can SCP-106 break doors?")]
        public bool scp106 { get; set; } = true;
    }
}
