using QLMA.Models;

namespace QLMA.Repository
{
    public interface INoiORepository
    {
        Task<IEnumerable<NoiO>> GetAllAsync();
        Task<NoiO?> GetByIdAsync(int id);
        Task AddAsync(NoiO noiO);
        Task UpdateAsync(NoiO noiO);
        Task DeleteAsync(int id);
    }
}
