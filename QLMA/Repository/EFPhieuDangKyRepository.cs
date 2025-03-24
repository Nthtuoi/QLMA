using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
   public class EFPhieuDangKyRepository : GenericRepository<PhieuDangKy>, IPhieuDangKyRepository
    {
        public EFPhieuDangKyRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<PhieuDangKy>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<PhieuDangKy?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(PhieuDangKy entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PhieuDangKy entity)
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
