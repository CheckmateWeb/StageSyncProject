using System;

namespace StageSync.Models.Tables
{
    public class TblStagesModel
    {
        public int stageID { get; set; }
        public string stageName { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public int capacity { get; set; }
        public decimal hourlyRate { get; set; }
        public string status { get; set; }
    }
}
