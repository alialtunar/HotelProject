using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.DataAccessLayer.EntityFramework
{
  public class EfAboutDal: GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context):base(context)
        {

        }
    }
}
