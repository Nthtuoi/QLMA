using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFQLDPTPRepository : GenericRepository<QLDPTP>, IQLDPTPRepository
    {
        public EFQLDPTPRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<QLDPTP>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<QLDPTP?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(QLDPTP entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(QLDPTP entity)
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
