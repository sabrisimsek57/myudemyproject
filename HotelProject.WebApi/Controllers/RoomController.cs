using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer;
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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomSService;

        public RoomController(IRoomService roomSService)
        {
            _roomSService = roomSService;
        }

        [HttpGet] 
        public IActionResult RoomList()
        {
            var values = _roomSService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room romm)
        {
            _roomSService.TInsert(romm);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomSService.TGetByID(id);
            _roomSService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomSService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomSService.TGetByID(id);
            return Ok(values);
        }

    }
}
