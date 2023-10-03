using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Project.DtoLayer.Dtos.RoomDto
{
   public class UpdateRoomDto
    {
        [Required(ErrorMessage = "lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        public string RoomCoverImaager { get; set; }
        [Required(ErrorMessage = "lütfen fiyat bilgisini giriniz ")]
        public int Price { get; set; }
        [Required(ErrorMessage = "lütfen oda başlıgını bilgisini giriniz ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "lütfen yatak sayısı bilgisini giriniz ")]
        public string BeadCount { get; set; }

        [Required(ErrorMessage = "lütfen banyo sayısı bilgisini giriniz ")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
