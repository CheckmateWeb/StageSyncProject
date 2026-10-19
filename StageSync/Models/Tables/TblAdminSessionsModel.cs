using System;

namespace StageSync.Models.Tables
{
    public class TblAdminSessionsModel
    {
        public int sessionID { get; set; }
        public int adminID { get; set; }
        public string sessionToken { get; set; }
        public DateTime expiresAt { get; set; }
    }
}
