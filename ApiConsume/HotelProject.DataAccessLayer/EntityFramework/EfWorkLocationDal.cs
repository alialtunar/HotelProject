using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject.DataAccessLayer.EntityFramework
{
   public class EfWorkLocationDal:GenericRepository<WorkLocation>,IWorkLocationDal
    {
        public EfWorkLocationDal(Context context):base(context)
        {

        }
    }
}
