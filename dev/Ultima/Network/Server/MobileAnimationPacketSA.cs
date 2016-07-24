/***************************************************************************
 *   MobileAnimationPacketPacketSA.cs
 *   Copyright (c) 2009 UltimaXNA Development Team
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using UltimaXNA.Core.Network;
using UltimaXNA.Core.Network.Packets;
#endregion

namespace UltimaXNA.Ultima.Network.Server
{
    public class MobileAnimationPacketSA : RecvPacket
    {
        readonly Serial m_serial;
        readonly short m_animationtype;
        readonly short m_action;
        readonly byte m_delay;

        public Serial Serial
        {
            get { return m_serial; } 
        }

        public short AnimationType
        {
            get { return m_animationtype; }
        }

        public short Action
        {
            get { return m_action; }
        }
        
        public byte Delay
        {
            get { return m_delay; }
        }

        public MobileAnimationPacketSA(PacketReader reader)
            : base(0xE2, "Mobile Animation SA")
        {
            m_serial = reader.ReadInt32();
            m_animationtype = reader.ReadInt16();
            m_action = reader.ReadInt16();
            m_delay = reader.ReadByte();
        }
    }
}
