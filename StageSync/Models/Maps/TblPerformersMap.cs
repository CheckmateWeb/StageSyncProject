using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblPerformersMap : EntityTypeConfiguration<TblPerformersModel>
    {
        public TblPerformersMap()
        {
            HasKey(k => k.performerID);
            ToTable("tbl_performers");
        }
    }
}
