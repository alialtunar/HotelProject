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
        void TBookingStatusChangeAproved3(int id);

        void TBookingStatusChangeCancel(int id);

        void TBookingStatusChangeWait(int id);
        int TGetBookingCount();

        List<Booking> TLast6Bookings();
    }
}
