﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserWorkLocationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageURL { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string WorkLocationName { get; set; }
        public int WorkLocationID { get; set; }

    }
}
