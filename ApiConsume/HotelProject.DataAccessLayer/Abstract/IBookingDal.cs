using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);

        int GetBookingCount();
        List<Booking> Last6Bookings();

        void BookingStatusChangeAproved3(int id);
        void BookingStatusChangeCancel(int id);

         void BookingStatusChangeWait(int id);
    }
}
