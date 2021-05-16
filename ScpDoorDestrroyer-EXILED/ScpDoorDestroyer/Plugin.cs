using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace ScpDoorDestroyer
{

    public  class Plugin : Plugin<Config>
    {
       

        public override string Author { get; } = "Space";

        public override string Name { get; } = "ScpDoorDestroyer";

        public override string Prefix { get; } = "ScpDoorDestroyer";

        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        public override Version Version { get; } = new Version(1, 0, 0);

        public EventHandlers EventHandler;

        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);

            Player.InteractingDoor += EventHandler.InteractingDoors;
            

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            this.EventHandler = null;

            base.OnDisabled();
        }
        
    }
}
