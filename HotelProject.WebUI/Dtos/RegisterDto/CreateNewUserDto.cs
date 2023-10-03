using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="ad alanı gereklidir")]
        public string Name { get; set; }

       [Required(ErrorMessage = "soyad alanı gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "kullanıcı adı alanı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "maail  alanı gereklidir")]
        public string mail { get; set; }
        [Required(ErrorMessage = "şifre  alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "şifre tekar alanı gereklidir")]
        [Compare("Password",ErrorMessage ="şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        
    }
}
