using System.ComponentModel.DataAnnotations;

namespace QLMA.Models
{
    public class NoiO
    {
        [Key]
        public int ID_NoiO { get; set; }
        public string?  TenNoiO { get; set; }
        public string? DiaChi { get; set; }
        public int Sogiuongcosan { get; set; }
        public string?  Lienhe { get; set; }
    }
}
