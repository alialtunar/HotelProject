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
    }
}
