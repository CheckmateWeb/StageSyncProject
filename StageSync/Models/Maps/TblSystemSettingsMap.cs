using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblSystemSettingsMap : EntityTypeConfiguration<TblSystemSettingsModel>
    {
        public TblSystemSettingsMap()
        {
            HasKey(k => k.settingKey);
            ToTable("tbl_system_settings");
            Property(p => p.settingKey).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
