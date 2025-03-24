using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Repository
{
    public class EFViecLamRepository : GenericRepository<ViecLam>, IViecLamRepository
{
    public EFViecLamRepository(QLMAContext context) : base(context) { }

    public async Task<IEnumerable<ViecLam>> GetAllViecLamAsync()
    {
        return await _dbSet.ToListAsync();
    }

        public async Task<ViecLam?> GetViecLamByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }


        public async Task AddViecLamAsync(ViecLam entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateViecLamAsync(ViecLam entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteViecLamAsync(int id)
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
