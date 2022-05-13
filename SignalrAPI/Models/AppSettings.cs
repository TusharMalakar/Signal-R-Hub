﻿namespace SignalrAPI.Models
{
    public class AppSettings
    {
        public string SqlConnectionString { get; set; }
        public string OmnizantDevWebHost { get; set; }
        public string OmnizantPMAWebHost { get; set; }
        public string OmnizantProductionWebHost { get; set; }
        public string ZolaCryptoPassWord { get; set; }
    }
}
