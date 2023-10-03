using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
       
            private readonly IStaffService staffService;
            private readonly IBookingService bookingService;
            private readonly IRoomService roomService;
            private readonly IAppUserService appUserService;

            public DashboardWidgetsController(
                IStaffService staffService,
                IBookingService bookingService,
                IRoomService roomService,
                IAppUserService appUserService)
            {
                this.staffService = staffService;
                this.bookingService = bookingService;
                this.roomService = roomService;
                this.appUserService = appUserService;
            }


       
        [HttpGet]
        public IActionResult StaffCount()
        {
            var values = staffService.TGetStaffCount();
            return Ok(values);
        }
        [HttpGet("Last4")]
        public IActionResult Last4()
        {
            var values = staffService.TLast4Staff();
            return Ok(values);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var values = bookingService.TGetBookingCounnt();
            return Ok(values);
        }
        [HttpGet("UserCount")]
        public IActionResult UserCount()
        {
            var values = appUserService.TAppUserCount();
            return Ok(values);
        }
        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var values = roomService.TRoomCount();
            return Ok(values);
        }
    }
}
