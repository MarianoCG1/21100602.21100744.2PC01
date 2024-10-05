using _21100602._21100744._2PC01.Entities;

namespace _21100602._21100744._2PC01.Interfaces
{
    public interface IAttendeesRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Attendees>> GetAll();
        Task<int> Insert(Attendees attendees);
    }
}