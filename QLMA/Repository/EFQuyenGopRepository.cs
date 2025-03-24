using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFQuyenGopRepository : GenericRepository<QuyenGop>, IQuyenGopRepository
    {
        public EFQuyenGopRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<QuyenGop>> GetAllQuyenGopAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<QuyenGop?> GetQuyenGopByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddQuyenGopAsync(QuyenGop entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateQuyenGopAsync(QuyenGop entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteQuyenGopAsync(int id)
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
