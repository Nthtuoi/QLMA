using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class QLDPTP
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("DiemPhatThucPham")]
        public int ID_DPTT { get; set; }
        public DiemPhatThucPham? DiemPhatThucPham { get; set; }

        [ForeignKey("ToChucTuThien")]
        public int ID_TCTT { get; set; }
        public ToChucTuThien? ToChucTuThien { get; set; }

        public string? TrangThai { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
