﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Booking
{
    public class BookingCoverPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
