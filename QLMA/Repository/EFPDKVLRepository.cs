using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFPhieuDKVLRepository : GenericRepository<PDKVL>, IPDKVLRepository
    {
        public EFPhieuDKVLRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<PDKVL>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<PDKVL?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(PDKVL entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PDKVL entity)
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
