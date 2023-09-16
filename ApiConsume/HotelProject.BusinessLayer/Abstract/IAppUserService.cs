using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();

        List<AppUser> TUsersListWithWorkLocations();

        int TAppUserCount();
    }
}
