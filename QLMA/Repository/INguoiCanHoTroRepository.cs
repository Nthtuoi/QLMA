using QLMA.Models;

namespace QLMA.Repository
{
    public interface INguoiCanHoTroRepository
    {
        Task<IEnumerable<NguoiCanHoTro>> GetAllNguoiCanHoTroAsync();
        Task<NguoiCanHoTro?> GetNguoiCanHoTroByIdAsync(int id);
        Task AddNguoiCanHoTroAsync(NguoiCanHoTro nguoiCanHoTro);
        Task UpdateNguoiCanHoTroAsync(NguoiCanHoTro nguoiCanHoTro);
        Task DeleteNguoiCanHoTroAsync(int id);
    }
}
