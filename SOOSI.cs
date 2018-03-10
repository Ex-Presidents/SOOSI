using System;
using Rocket.Core.Plugins;

namespace SOOSI
{
    public class SOOSI : RocketPlugin<PluginConfig>
    {
        public static SOOSI Instance;
        public String Connection;
        
        protected override void Load()
        {
            Instance = this;
            
            Connection = $"SERVER={Configuration.Instance.Address};" +
                         $"UID={Configuration.Instance.UID};" +
                         $"PASSWORD={Configuration.Instance.Password};" +
                         $"DATABASE={Configuration.Instance.Database};" +
                         $"PORT={Configuration.Instance.Port}";
            
            DatabaseHandler.CreateTables();
        }
    }
}