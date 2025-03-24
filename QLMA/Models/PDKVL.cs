using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class PDKVL
    {
        [Key]
        public int ID_PDKVL { get; set; }
        public DateTime NgayUngTuyen { get; set; }
        public string? TrangThai { get; set; }

        [ForeignKey("NguoiCanHoTro")]
        public int ID_NguoiDangKy { get; set; }
        public NguoiCanHoTro?  NguoiDangKy { get; set; }
    }
}
