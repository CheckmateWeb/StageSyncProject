using System;

namespace StageSync.Models.Tables
{
    public class TblAnnouncementsModel
    {
        public int announcementID { get; set; }
        public int postedBy { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public bool isPublished { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
