using System;

namespace StageSync.Models.Tables
{
    public class TblPerformersModel
    {
        public int performerID { get; set; }
        public int typeID { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string contactNumber { get; set; }
        public string passwordHash { get; set; }
        public string status { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
