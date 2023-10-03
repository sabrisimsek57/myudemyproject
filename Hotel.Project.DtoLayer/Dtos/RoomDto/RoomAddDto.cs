using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Project.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
     
        public int RoomID { get; set; }

        [Required (ErrorMessage ="lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        public string RoomCoverImaager { get; set; }
        [Required(ErrorMessage = "lütfen fiyat bilgisini giriniz ")]
        public int Price { get; set; }
        [Required(ErrorMessage = "lütfen oda başlıgını bilgisini giriniz ")]
        [StringLength(100,ErrorMessage ="lütfen en fazla 100 karakter veri girişi yapınız")]
        [MinLength(1,ErrorMessage ="en az 1 karakter veri girişi yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "lütfen yatak sayısı bilgisini giriniz ")]
        public string BeadCount { get; set; }

        [Required(ErrorMessage = "lütfen banyo sayısı bilgisini giriniz ")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "lütfen acıklama bilgisini giriniz ")]
        public string Description { get; set; }
    }
}
