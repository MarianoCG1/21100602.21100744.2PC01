using _21100602._21100744._2PC01.Data;
using _21100602._21100744._2PC01.Entities;
using _21100602._21100744._2PC01.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _21100602._21100744._2PC01.Repositorios
{
    public class AttendeesRepository : IAttendeesRepository
    {
        private readonly EventManagementDbContext _dbContext;

        public AttendeesRepository(EventManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Attendees>> GetAll()
        {
            var attendees = await _dbContext.Attendees.Where(a => a.Id != 0).ToListAsync();
            return attendees;
        }

        public async Task<int> Insert(Attendees attendees)
        {
            await _dbContext.Attendees.AddAsync(attendees);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? attendees.Id : -1;
        }


        public async Task<bool> Delete(int id)
        {
            var attendees = await _dbContext.Attendees.FirstOrDefaultAsync(a => a.Id == id);
            _dbContext.Attendees.Remove(attendees);

            if (attendees == null) return false;
            return true;
        }




    }
}
