using QLMA.Models;

namespace QLMA.Repository
{
    public interface IPDKVLRepository
    {
        Task<IEnumerable<PDKVL>> GetAllAsync();
        Task<PDKVL?> GetByIdAsync(int id);
        Task AddAsync(PDKVL PDKVL);
        Task UpdateAsync(PDKVL PDKVL);
        Task DeleteAsync(int id);
    }
}
