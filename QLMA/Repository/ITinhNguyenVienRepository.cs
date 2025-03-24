using QLMA.Models;

namespace QLMA.Repository
{
    public interface ITinhNguyenVienRepository
    {
        Task<IEnumerable<TinhNguyenVien>> GetAllTinhNguyenVienAsync();
        Task<TinhNguyenVien?> GetTinhNguyenVienByIdAsync(int id);
        Task AddTinhNguyenVienAsync(TinhNguyenVien tinhNguyenVien);
        Task UpdateTinhNguyenVienAsync(TinhNguyenVien tinhNguyenVien);
        Task DeleteTinhNguyenVienAsync(int id);
    }
}
