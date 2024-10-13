

using Shared.Models;

namespace Exir.Interfaces
{
    public interface IProfileRepository
    {
        Task<Profile?> GetByIdAsync(int id);
        Task<List<Profile>> GetAllAsync();
    }
}
