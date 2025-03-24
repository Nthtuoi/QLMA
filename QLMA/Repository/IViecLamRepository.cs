using QLMA.Models;

namespace QLMA.Repository
{
    public interface IViecLamRepository
    {
        Task<IEnumerable<ViecLam>> GetAllViecLamAsync();
        Task<ViecLam?> GetViecLamByIdAsync(int id);
        Task AddViecLamAsync(ViecLam viecLam);
        Task UpdateViecLamAsync(ViecLam viecLam);
        Task DeleteViecLamAsync(int id);
    }
}
