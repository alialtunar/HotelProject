﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
