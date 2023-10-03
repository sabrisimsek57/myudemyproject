﻿using HotelProject.DataAccsessLayer.Abstract;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IRoomDal : IGenericDal<Room>
    {
        int RoomCount();
    }
}
