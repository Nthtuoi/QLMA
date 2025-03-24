using QLMA.Models;

namespace QLMA.Repository
{
    public interface IQLDPTPRepository
    {
        Task<IEnumerable<QLDPTP>> GetAllAsync();
        Task<QLDPTP?> GetByIdAsync(int id);
        Task AddAsync(QLDPTP qlDPTP);
        Task UpdateAsync(QLDPTP qlDPTP);
        Task DeleteAsync(int id);
    }
}
