using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFDiemPhatThucPhamRepository : GenericRepository<DiemPhatThucPham>, IDiemPhatThucPhamRepository
    {
        public EFDiemPhatThucPhamRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<DiemPhatThucPham>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<DiemPhatThucPham?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(DiemPhatThucPham entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DiemPhatThucPham entity)
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
