using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class PhieuDangKy
    {
        [Key]
        public int ID_PDK { get; set; }
        public string? LoaiDangKy { get; set; }
        public int ID_NguoiDangKy { get; set; }
        public string? TrangThai { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string?  CCCD { get; set; }
        public int ID_NoiO { get; set; }
    }
}
