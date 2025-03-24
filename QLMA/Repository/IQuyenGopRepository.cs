using QLMA.Models;

namespace QLMA.Repository
{
    public interface IQuyenGopRepository
    {
        Task<IEnumerable<QuyenGop>> GetAllQuyenGopAsync();
        Task<QuyenGop?> GetQuyenGopByIdAsync(int id);
        Task AddQuyenGopAsync(QuyenGop quyenGop);
        Task UpdateQuyenGopAsync(QuyenGop quyenGop);
        Task DeleteQuyenGopAsync(int id);
    }
}
