using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer
{
  public  class Room
    {
        [Key]
        public int RoomID { get; set; }

        public string RoomNumber { get; set; }
        public string RoomCoverImaager { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BeadCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
