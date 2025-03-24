using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFBaoCaoThongKeRepository : GenericRepository<BaoCaoThongKe>, IBaoCaoThongKeRepository
    {
        public EFBaoCaoThongKeRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<BaoCaoThongKe>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<BaoCaoThongKe?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(BaoCaoThongKe entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BaoCaoThongKe entity)
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
