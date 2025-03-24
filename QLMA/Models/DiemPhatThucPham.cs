using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class DiemPhatThucPham
    {
        [Key]
        public int ID_DPTT { get; set; }
        public string? TenDiem { get; set; }
        public string? DiaChi { get; set; }
        public int ID_ToChucTuThien { get; set; }
    }
}
