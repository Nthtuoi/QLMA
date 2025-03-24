using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class NhaTuyenDung
    {
        [Key]
        public int ID_NTD { get; set; }
        public string? TenCongTy { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
    }
}
