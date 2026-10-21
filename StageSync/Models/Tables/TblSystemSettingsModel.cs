using System;

namespace StageSync.Models.Tables
{
    public class TblSystemSettingsModel
    {
        public string settingKey { get; set; }
        public string settingValue { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
