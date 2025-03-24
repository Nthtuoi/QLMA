using QLMA.Models;

namespace QLMA.Repository
{
    public interface IAdminRepository
    {
        Task<IEnumerable<ADMIN>> GetAllAdminsAsync();
        Task<ADMIN?> GetAdminByIdAsync(int id);
        Task AddAdminAsync(ADMIN admin);
        Task UpdateAdminAsync(ADMIN admin);
        Task DeleteAdminAsync(int id);
    }
}
