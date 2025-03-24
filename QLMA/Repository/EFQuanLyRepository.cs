using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFQuanLyRepository : GenericRepository<QuanLy>, IQuanLyRepository
    {
        public EFQuanLyRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<QuanLy>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<QuanLy?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(QuanLy entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(QuanLy entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
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
