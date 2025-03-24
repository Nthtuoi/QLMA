using QLMA.Models;

namespace QLMA.Repository
{
    public interface IPhieuDangKyRepository
    {
        Task<IEnumerable<PhieuDangKy>> GetAllAsync();
        Task<PhieuDangKy?> GetByIdAsync(int id);
        Task AddAsync(PhieuDangKy phieuDangKy);
        Task UpdateAsync(PhieuDangKy phieuDangKy);
        Task DeleteAsync(int id);
    }
}
