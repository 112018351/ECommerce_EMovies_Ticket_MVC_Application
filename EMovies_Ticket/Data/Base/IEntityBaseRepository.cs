using EMovies_Ticket.Models;

namespace EMovies_Ticket.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllActorsAsync();
        Task<T> GetByIdAsync(int id);

        Task AddActorAsync(T entity);
        Task UpdateActorAsync(int id, T entity);

        Task DeleteActorAsync(int id);
    }
}
