using System;

namespace StageSync.Models.Tables
{
    public class TblStageSchedulesModel
    {
        public int scheduleID { get; set; }
        public int stageID { get; set; }
        public int createdBy { get; set; }
        public DateTime scheduleDate { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public string status { get; set; }
    }
}
