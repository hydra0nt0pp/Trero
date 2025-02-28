﻿#region

using Trero.ClientBase;
using Trero.Modules.vModuleExtra;

#endregion

namespace Trero.Modules
{
    internal class PhaseUp : Module
    {
        public PhaseUp() : base("PhaseUp", (char)0x07, "Flies", "Slowly phase upwards")
        {
            addBypass(new BypassBox(new string[] { "Default", "Fast", "Super Fast" }));
        } // Not defined

        public override void OnTick()
        {
            Game.velocity = Base.Vec3();

            var newPos = Game.position;
            if (bypasses[0].curIndex == 0)
                newPos.y += 0.01f;
            if (bypasses[0].curIndex == 1)
                newPos.y += 0.01f;
            if (bypasses[0].curIndex == 2)
                newPos.y += 0.1f;
            Game.position = newPos;
        }
    }
}