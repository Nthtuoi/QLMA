using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace QLMA.Models
{
    public class ADMIN : IdentityUser
    {
        [Key]
        public int ID_AD { get; set; }
        public string? HoTen { get; set; }
        public string? SDT { get; set; }
        //public string? Email { get; set; }
        public string?  MatKhau { get; set; }
    }
}
