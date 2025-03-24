using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFNhaHaoTamRepository : GenericRepository<NhaHaoTam>, INhaHaoTamRepository
    {
        public EFNhaHaoTamRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<NhaHaoTam>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<NhaHaoTam?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(NhaHaoTam entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(NhaHaoTam entity)
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
