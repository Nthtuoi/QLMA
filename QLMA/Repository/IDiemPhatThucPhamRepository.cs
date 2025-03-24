using QLMA.Models;

namespace QLMA.Repository
{
    public interface IDiemPhatThucPhamRepository
    {
        Task<IEnumerable<DiemPhatThucPham>> GetAllAsync();
        Task<DiemPhatThucPham?> GetByIdAsync(int id);
        Task AddAsync(DiemPhatThucPham diemPhat);
        Task UpdateAsync(DiemPhatThucPham diemPhat);
        Task DeleteAsync(int id);
    }
}
