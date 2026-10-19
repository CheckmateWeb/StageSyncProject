using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblAnnouncementsMap : EntityTypeConfiguration<TblAnnouncementsModel>
    {
        public TblAnnouncementsMap()
        {
            HasKey(k => k.announcementID);
            ToTable("tbl_announcements");
        }
    }
}
