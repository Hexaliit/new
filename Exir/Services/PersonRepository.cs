using Exir.Data;
using Exir.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Exir.Services
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PersonRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task CreateAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await dbContext
                .Persons
                .Include(p => p.Profile)
                .ToListAsync();
        }

        public async Task<Person?> GetByIdAsync(int id)
        {
            return await dbContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
