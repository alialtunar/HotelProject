using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        List<AppUser> UsersListWithWorkLocations();

        int AppUserCount();
    }
}
