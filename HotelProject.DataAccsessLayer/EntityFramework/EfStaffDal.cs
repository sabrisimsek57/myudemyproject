﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;

using HotelProject.DataAccsessLayer.Concrete;
using HotelProject.DataAccsessLayer.Repositories;
using HotelProject.EntityLayer;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {

        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var value = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return (value);
        }
    }
}
