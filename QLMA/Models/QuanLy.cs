using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class QuanLy
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Admin")]
        public int ID_Admin { get; set; }
        public ADMIN? Admin { get; set; }

        public string? TenBang { get; set; }
        public int ID_Bang { get; set; }
        public string? LoaiHanhDong { get; set; }
        public string? GhiChu { get; set; }
        public DateTime NgayThucHien { get; set; }
    }
}
