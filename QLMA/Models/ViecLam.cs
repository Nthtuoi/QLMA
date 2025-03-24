using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class ViecLam
    {
        [Key]
        public int ID_VL { get; set; }
        public string? TenViec { get; set; }
        public string? MoTa { get; set; }
        public decimal MucLuong { get; set; }
        public string? Yeucaukynang { get; set; }

        [ForeignKey("NhaTuyenDung")]
        public int ID_NhaTuyenDung { get; set; }
        public NhaTuyenDung? NhaTuyenDung { get; set; }
    }
}
