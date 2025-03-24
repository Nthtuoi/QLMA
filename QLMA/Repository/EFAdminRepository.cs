using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFAdminRepository : GenericRepository<ADMIN>, IAdminRepository
    {
        public EFAdminRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<ADMIN>> GetAllAdminsAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<ADMIN?> GetAdminByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAdminAsync(ADMIN admin)
        {
            await _dbSet.AddAsync(admin);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAdminAsync(ADMIN admin)
        {
            _dbSet.Update(admin);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdminAsync(int id)
        {
            var admin = await _dbSet.FindAsync(id);
            if (admin != null)
            {
                _dbSet.Remove(admin);
                await _context.SaveChangesAsync();
            }
        }
    }

}
