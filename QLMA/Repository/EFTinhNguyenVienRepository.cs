using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFTinhNguyenVienRepository : GenericRepository<TinhNguyenVien>, ITinhNguyenVienRepository
    {
        public EFTinhNguyenVienRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<TinhNguyenVien>> GetAllTinhNguyenVienAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TinhNguyenVien?> GetTinhNguyenVienByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddTinhNguyenVienAsync(TinhNguyenVien entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTinhNguyenVienAsync(TinhNguyenVien entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTinhNguyenVienAsync(int id)
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
