using QLMA.Models;

namespace QLMA.Repository
{
    public interface INhaTuyenDungRepository
    {
        Task<IEnumerable<NhaTuyenDung>> GetAllAsync();
        Task<NhaTuyenDung?> GetByIdAsync(int id);
        Task AddAsync(NhaTuyenDung nhaTuyenDung);
        Task UpdateAsync(NhaTuyenDung nhaTuyenDung);
        Task DeleteAsync(int id);
    }
}
