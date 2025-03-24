using QLMA.Models;

namespace QLMA.Repository
{
    public interface IQuanLyRepository
    {
        Task<IEnumerable<QuanLy>> GetAllAsync();
        Task<QuanLy?> GetByIdAsync(int id);
        Task AddAsync(QuanLy quanLy);
        Task UpdateAsync(QuanLy quanLy);
        Task DeleteAsync(int id);
    }
}
