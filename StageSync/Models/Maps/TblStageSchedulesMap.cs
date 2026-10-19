using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblStageSchedulesMap : EntityTypeConfiguration<TblStageSchedulesModel>
    {
        public TblStageSchedulesMap()
        {
            HasKey(k => k.scheduleID);
            ToTable("tbl_stage_schedules");
        }
    }
}
