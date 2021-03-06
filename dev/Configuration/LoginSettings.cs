/***************************************************************************
 *   ServerSettings.cs
 *   Copyright (c) 2015 UltimaXNA Development Team
 * 
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using UltimaXNA.Core.Configuration;
#endregion

namespace UltimaXNA.Configuration
{
    public sealed class LoginSettings : ASettingsSection
    {
        public const string SectionName = "server";

        private string m_ServerAddress;
        private int m_ServerPort;
        private string m_UserName;
        private bool m_AutoSelectLastCharacter;
        private string m_LastCharacterName;

        public LoginSettings()
        {
            //ServerAddress = "64.94.238.203";
            ServerAddress = "login.uogamers.com";
            ServerPort = 2593;
            LastCharacterName = string.Empty;
            AutoSelectLastCharacter = false;
        }

        public string UserName
        {
            get { return m_UserName; }
            set { SetProperty(ref m_UserName, value); }
        }

        public int ServerPort
        {
            get { return m_ServerPort; }
            set { SetProperty(ref m_ServerPort, value); }
        }

        public string ServerAddress
        {
            get { return m_ServerAddress; }
            set { SetProperty(ref m_ServerAddress, value); }
        }

        public string LastCharacterName
        {
            get { return m_LastCharacterName; }
            set { SetProperty(ref m_LastCharacterName, value); }
        }

        public bool AutoSelectLastCharacter
        {
            get { return m_AutoSelectLastCharacter; }
            set { SetProperty(ref m_AutoSelectLastCharacter, value); }
        }
    }
}