using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using Interactables.Interobjects.DoorUtils;

namespace ScpDoorDestroyer
{
    public class EventHandlers 
    {
        public Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        
        public void InteractingDoors(InteractingDoorEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scp173 && plugin.Config.scp173)
            {
                if (ev.Door is IDamageableDoor scpdoor173)
                {
                    scpdoor173.IsDestroyed = true;
                }

            }
            if (ev.Player.Role == RoleType.Scp049 && plugin.Config.scp049)
                if (ev.Door is IDamageableDoor scpdoor049)
                {
                    scpdoor049.IsDestroyed = true;
                }
            if (ev.Player.Role == RoleType.Scp096 && plugin.Config.scp096)
            {
                if (ev.Door is IDamageableDoor scpdoor096)
                {
                    scpdoor096.IsDestroyed = true;
                }
            }
            if (ev.Player.Role == RoleType.Scp93953 && plugin.Config.scp93953)

                if (ev.Door is IDamageableDoor scpdoor93953)
                {
                    scpdoor93953.IsDestroyed = true;
                }
            if (ev.Player.Role == RoleType.Scp93989 && plugin.Config.scp93989)

                if (ev.Door is IDamageableDoor scpdoor93989)
                {
                    scpdoor93989.IsDestroyed = true;
                }
            if (ev.Player.Role == RoleType.Scp0492 && plugin.Config.scp0492)

                if (ev.Door is IDamageableDoor scpdoor0492)
                {
                    scpdoor0492.IsDestroyed = true;
                }
            if (ev.Player.Role == RoleType.Scp106 && plugin.Config.scp106)

               if (ev.Door is IDamageableDoor scpdoor106)
                {
                    scpdoor106.IsDestroyed = true;
                }


        }
    }
}
