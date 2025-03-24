using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace QLMA.Models
{
    public class NguoiCanHoTro
    {
        [Key]
        public int ID_NCHT { get; set; }
        public string? HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
    }
}
