using Exir.Data;
using Exir.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Exir.Services
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProfileRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Profile>> GetAllAsync()
        {
            return await dbContext.Profiles.ToListAsync();
        }

        public async Task<Profile?> GetByIdAsync(int id)
        {
            return await dbContext.Profiles.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
