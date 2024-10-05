using _21100602._21100744._2PC01.Data;
using _21100602._21100744._2PC01.Entities;
using _21100602._21100744._2PC01.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _21100602._21100744._2PC01.Repositorios
{
    public class OrganizersRepository : IOrganizersRepository
    {
        private readonly EventManagementDbContext _dbContext;

        public OrganizersRepository(EventManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Organizers>> GetAll()
        {
            var organizers = await _dbContext.Organizers.Where(a => a.Id != 0).ToListAsync();
            return organizers;
        }

        public async Task<int> Insert(Organizers organizers)
        {
            await _dbContext.Organizers.AddAsync(organizers);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? organizers.Id : -1;
        }


        public async Task<bool> Delete(int id)
        {
            var organizers = await _dbContext.Organizers.FirstOrDefaultAsync(a => a.Id == id);
            _dbContext.Organizers.Remove(organizers);

            if (organizers == null) return false;
            return true;
        }
    }
}
