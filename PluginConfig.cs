using System;
using Rocket.API;

namespace SOOSI
{
    public class PluginConfig : IRocketPluginConfiguration
    {
        public String Address;
        public String UID;
        public String Password;
        public String Database;
        public ushort Port;
        
        public void LoadDefaults()
        {
            Address = "localhost";
            UID = "root";
            Password = "P@ssword123";
            Database = "SOOSI";
            Port = 3306;
        }
    }
}