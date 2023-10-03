using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Himzet ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Himzet başlıgı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlıgı en fazla 100 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Himzet Açıklaması giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]

        public string Description { get; set; }
    }
}
