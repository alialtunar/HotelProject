using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.EntityLayer.Concrete
{
   public class Guest
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
