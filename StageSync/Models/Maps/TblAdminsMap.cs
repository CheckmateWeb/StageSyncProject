using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblAdminsMap : EntityTypeConfiguration<TblAdminsModel>
    {
        public TblAdminsMap()
        {
            HasKey(k => k.adminID);
            ToTable("tbl_admins");
        }
    }
}
