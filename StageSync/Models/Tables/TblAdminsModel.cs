using System;

namespace StageSync.Models.Tables
{
    public class TblAdminsModel
    {
        public int adminID { get; set; }
        public string username { get; set; }
        public string passwordHash { get; set; }
        public string role { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
