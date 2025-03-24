using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFNoiORepository : GenericRepository<NoiO>, INoiORepository
    {
        public EFNoiORepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<NoiO>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<NoiO?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(NoiO entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(NoiO entity)
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
