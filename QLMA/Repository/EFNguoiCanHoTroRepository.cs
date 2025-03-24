using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFNguoiCanHoTroRepository : GenericRepository<NguoiCanHoTro>, INguoiCanHoTroRepository
    {
        public EFNguoiCanHoTroRepository(QLMAContext context) : base(context) { }
        public async Task<IEnumerable<NguoiCanHoTro>> GetAllNguoiCanHoTroAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<NguoiCanHoTro?> GetNguoiCanHoTroByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddNguoiCanHoTroAsync(NguoiCanHoTro entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNguoiCanHoTroAsync(NguoiCanHoTro entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNguoiCanHoTroAsync(int id)
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
