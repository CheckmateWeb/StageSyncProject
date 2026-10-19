using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblBookingRequestsMap : EntityTypeConfiguration<TblBookingRequestsModel>
    {
        public TblBookingRequestsMap()
        {
            HasKey(k => k.bookingID);
            ToTable("tbl_booking_requests");
        }
    }
}
