using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblStagesMap : EntityTypeConfiguration<TblStagesModel>
    {
        public TblStagesMap()
        {
            HasKey(k => k.stageID);
            ToTable("tbl_stages");
        }
    }
}
