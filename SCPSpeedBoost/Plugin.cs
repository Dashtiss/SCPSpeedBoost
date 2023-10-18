using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SCPSpeedBoost
{
    public class Plugin : Plugin<Config>
    {
        EventHandlers eventHandlers;
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Player.ChangingRole += eventHandlers.OnRoleChange;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Player.ChangingRole -= eventHandlers.OnRoleChange;
            base.OnDisabled();
        }
    }
}
