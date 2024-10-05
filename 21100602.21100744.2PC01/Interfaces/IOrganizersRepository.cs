using _21100602._21100744._2PC01.Entities;

namespace _21100602._21100744._2PC01.Interfaces
{
    public interface IOrganizersRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Organizers>> GetAll();
        Task<int> Insert(Organizers organizers);
    }
}