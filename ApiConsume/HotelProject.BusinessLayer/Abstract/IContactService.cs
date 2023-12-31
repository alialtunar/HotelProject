﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IContactService:IGenericService<Contact>
    {
        public int TGetContactCount();
    }
}
