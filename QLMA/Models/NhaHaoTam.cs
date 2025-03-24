using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class NhaHaoTam
    {
        [Key]
        public int ID_NHT { get; set; }
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string?  Email { get; set; }
    }
}
