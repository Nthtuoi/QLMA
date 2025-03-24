using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class QuyenGop
    {
        [Key]
        public int ID { get; set; }
        public int ID_NhaHaoTam { get; set; }
        public int ID_ToChucTuThien { get; set; }
        public float Soluong { get; set; }
        public string?  LoaiQG { get; set; }
        public DateTime NgayGop { get; set; }
    }
}
