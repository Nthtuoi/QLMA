using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFNhaTuyenDungRepository : GenericRepository<NhaTuyenDung>, INhaTuyenDungRepository
    {
        public EFNhaTuyenDungRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<NhaTuyenDung>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<NhaTuyenDung?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(NhaTuyenDung entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(NhaTuyenDung entity)
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
