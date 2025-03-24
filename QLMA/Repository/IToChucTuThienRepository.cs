using QLMA.Models;

namespace QLMA.Repository
{
    public interface IToChucTuThienRepository
    {
        Task<IEnumerable<ToChucTuThien>> GetAllAsync();
        Task<ToChucTuThien?> GetToChucTuThienByIdAsync(int id);
        Task AddToChucTuThienAsync(ToChucTuThien toChucTuThien);
        Task UpdateToChucTuThienAsync(ToChucTuThien toChucTuThien);
        Task DeleteToChucTuThienAsync(int id);
    }
}
