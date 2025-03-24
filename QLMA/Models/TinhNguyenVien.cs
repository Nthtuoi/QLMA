using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class TinhNguyenVien
    {
        [Key]
        public int ID_TNV { get; set; }
        public string? HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string?  CCCD { get; set; }

        [ForeignKey("ToChucTuThien")]
        public int ID_ToChucTuThien { get; set; }
        public ToChucTuThien? ToChucTuThien { get; set; }
    }
}
