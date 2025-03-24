using QLMA.Models;

namespace QLMA.Repository
{
    public interface INhaHaoTamRepository
    {
        Task<IEnumerable<NhaHaoTam>> GetAllAsync();
        Task<NhaHaoTam?> GetByIdAsync(int id);
        Task AddAsync(NhaHaoTam nhaHaoTam);
        Task UpdateAsync(NhaHaoTam nhaHaoTam);
        Task DeleteAsync(int id);
    }
}
