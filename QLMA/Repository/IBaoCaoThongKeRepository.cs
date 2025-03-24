using QLMA.Models;

namespace QLMA.Repository
{
    public interface IBaoCaoThongKeRepository
    {
        Task<IEnumerable<BaoCaoThongKe>> GetAllAsync();
        Task<BaoCaoThongKe?> GetByIdAsync(int id);
        Task AddAsync(BaoCaoThongKe baoCao);
        Task UpdateAsync(BaoCaoThongKe baoCao);
        Task DeleteAsync(int id);
    }
}
