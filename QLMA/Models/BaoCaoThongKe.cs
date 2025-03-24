using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class BaoCaoThongKe
    {
        [Key]
        public int ID_BaoCao { get; set; }
        public string? TenBaoCao { get; set; }
        public DateTime NgayTao { get; set; }
        public string? LoaiBaoCao { get; set; }
        public int SoLuong { get; set; }
        public string?   GhiChu { get; set; }
    }
}
