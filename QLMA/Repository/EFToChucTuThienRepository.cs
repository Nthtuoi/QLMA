using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFToChucTuThienRepository : GenericRepository<ToChucTuThien>, IToChucTuThienRepository
    {
        public EFToChucTuThienRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<ToChucTuThien>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<ToChucTuThien?> GetToChucTuThienByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddToChucTuThienAsync(ToChucTuThien entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateToChucTuThienAsync(ToChucTuThien entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteToChucTuThienAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }

}
