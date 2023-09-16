using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        void TBookingStatusChangeApproved2(int id);

        int TGetBookingCount();

        List<Booking> TLast6Bookings();
    }
}
