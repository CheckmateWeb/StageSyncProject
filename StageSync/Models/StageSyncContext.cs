using System.Data.Entity;
using MySql.Data.EntityFramework;
using StageSync.Models.Tables;
using StageSync.Models.Maps;

namespace StageSync.Models.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StageSyncContext : DbContext
    {
        static StageSyncContext()
        {
            Database.SetInitializer<StageSyncContext>(null);
        }

        public StageSyncContext() : base("Name=DefaultConnection")
        {
        }

        public virtual DbSet<TblAdminsModel> tbl_admins { get; set; }
        public virtual DbSet<TblAdminSessionsModel> tbl_admin_sessions { get; set; }
        public virtual DbSet<TblAnnouncementsModel> tbl_announcements { get; set; }
        public virtual DbSet<TblCmsContentsModel> tbl_cms_contents { get; set; }
        public virtual DbSet<TblSystemSettingsModel> tbl_system_settings { get; set; }
        public virtual DbSet<TblPerformerTypesModel> tbl_performer_types { get; set; }
        public virtual DbSet<TblPerformersModel> tbl_performers { get; set; }
        public virtual DbSet<TblStagesModel> tbl_stages { get; set; }
        public virtual DbSet<TblStageSchedulesModel> tbl_stage_schedules { get; set; }
        public virtual DbSet<TblBookingRequestsModel> tbl_booking_requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new TblAdminsMap());
            modelBuilder.Configurations.Add(new TblAdminSessionsMap());
            modelBuilder.Configurations.Add(new TblAnnouncementsMap());
            modelBuilder.Configurations.Add(new TblCmsContentsMap());
            modelBuilder.Configurations.Add(new TblSystemSettingsMap());
            modelBuilder.Configurations.Add(new TblPerformerTypesMap());
            modelBuilder.Configurations.Add(new TblPerformersMap());
            modelBuilder.Configurations.Add(new TblStagesMap());
            modelBuilder.Configurations.Add(new TblStageSchedulesMap());
            modelBuilder.Configurations.Add(new TblBookingRequestsMap());
        }
    }
}
