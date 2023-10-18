using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSpeedBoost
{
    public class Config : IConfig
    {

        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        [Description("Can Zombies (SCP-049-2) get the speed effect")]
        public bool ZombieEffect { get; set; } = true;

        [Description("how much speed you can give. max is 255")]
        public byte MaxSpeed { get; set; } = 100;
    }
}
