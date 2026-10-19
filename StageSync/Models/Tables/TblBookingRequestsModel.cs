using System;

namespace StageSync.Models.Tables
{
    public class TblBookingRequestsModel
    {
        public int bookingID { get; set; }
        public int performerID { get; set; }
        public int scheduleID { get; set; }
        public int? processedBy { get; set; }
        public string eventTitle { get; set; }
        public int attendees { get; set; }
        public decimal totalAmount { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }
    }
}
