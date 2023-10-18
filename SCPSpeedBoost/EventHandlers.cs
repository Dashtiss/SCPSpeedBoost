using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.Loader.Features;
using PlayerRoles;

namespace SCPSpeedBoost
{
    public class EventHandlers
    {
        private Config Config;
        public void OnRoundStarted()
        {
            Config = new Config();
            foreach (Player player in Player.List)    
            {
                Log.Debug($"Checking player: {player.DisplayNickname} | Role: {player.Role.Name} | Id: {player.Id}");
                if (player.Role.Team == Team.SCPs)
                {
                    Log.Debug("Player is a SCP");
                    player.EnableEffect(EffectType.MovementBoost);
                    player.ChangeEffectIntensity(EffectType.MovementBoost, Config.MaxSpeed);
                }
            }
        }
        public void OnRoleChange(Exiled.Events.EventArgs.Player.ChangingRoleEventArgs ev)
        {
            Config = new Config();
            if (ev.NewRole == RoleTypeId.Scp0492)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost);
                ev.Player.ChangeEffectIntensity(EffectType.MovementBoost, Config.MaxSpeed);
            }
        }
    }
}
