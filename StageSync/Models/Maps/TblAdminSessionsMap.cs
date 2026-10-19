using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblAdminSessionsMap : EntityTypeConfiguration<TblAdminSessionsModel>
    {
        public TblAdminSessionsMap()
        {
            HasKey(k => k.sessionID);
            ToTable("tbl_admin_sessions");
        }
    }
}
