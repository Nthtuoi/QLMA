using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace QLMA.Models
{
    public class QLMAContext : IdentityDbContext<ADMIN>
    {
        public QLMAContext(DbContextOptions<QLMAContext> options) : base(options) { }
        // Khai báo các bảng trong database
        public DbSet<NguoiCanHoTro>? NguoiCanHoTros { get; set; }
        public DbSet<ToChucTuThien>? ToChucTuThiens { get; set; }
        public DbSet<TinhNguyenVien>? TinhNguyenViens { get; set; }
        public DbSet<NhaHaoTam>? NhaHaoTams { get; set; }
        public DbSet<NhaTuyenDung>? NhaTuyenDungs { get; set; }
        public DbSet<ViecLam>? ViecLams { get; set; }
        public DbSet<NoiO>? NoiOs { get; set; }
        public DbSet<PhieuDangKy>? PhieuDangKies { get; set; }
        public DbSet<PDKVL>? PhieuDKVLs { get; set; }
        public DbSet<DiemPhatThucPham>? DiemPhatThucPhams { get; set; }
        public DbSet<QLDPTP>? QLDPTTs { get; set; }
        public DbSet<QuyenGop>? QuyenGops { get; set; }
        public DbSet<ADMIN>? Admins { get; set; }
        public DbSet<QuanLy>? QuanLys { get; set; }
        public DbSet<BaoCaoThongKe>?     BaoCaoThongKes { get; set; }

    }
}
