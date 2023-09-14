using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.DataAccessLayer.Abstract
{
   public interface IContactDal:IGenericDal<Contact>
    {
       public int GetContactCount();
    }
}
