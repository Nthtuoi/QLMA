using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class ToChucTuThien
    {
        [Key]
        public int ID_TCTT { get; set; }
        public string? TenToChuc { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string?   Loaihinhhotro { get; set; }
    }
}
