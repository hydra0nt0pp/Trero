﻿#region

using System.Threading;
using System.Windows.Forms;
using Trero.ClientBase;
using Trero.ClientBase.UIBase;

#endregion

namespace Trero.Modules
{
    internal class Velocity : Module
    {
        public Velocity() : base("Velocity", (char)0x07, "Player", "Anti-Knockback, stop all knockback.", false)
        {
        } // Not defined

        public override void OnEnable()
        {
            base.OnEnable();

            MCM.writeBaseBytes(0x1DEF472, MCM.ceByte2Bytes("90 90 90 90 90 90"));
            MCM.writeBaseBytes(0x1DEF47B, MCM.ceByte2Bytes("90 90 90 90 90 90"));
            MCM.writeBaseBytes(0x1DEF484, MCM.ceByte2Bytes("90 90 90 90 90 90"));
        }

        public override void OnDisable() // sus
        {
            base.OnDisable();

            MCM.writeBaseBytes(0x1DEF472, MCM.ceByte2Bytes("89 81 F8 04 00 00"));
            MCM.writeBaseBytes(0x1DEF47B, MCM.ceByte2Bytes("89 81 FC 04 00 00"));
            MCM.writeBaseBytes(0x1DEF484, MCM.ceByte2Bytes("89 81 00 05 00 00"));
        }
    }
}
// Minecraft.Windows.exe+1D6AC7B 
// Minecraft.Windows.exe+1D6AC84 
