
using EMovies_Ticket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EMovies_Ticket.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
                this._context = context;
        }

        public async Task AddActorAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
           await  _context.SaveChangesAsync();

        }
        public async Task DeleteActorAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
           await  _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllActorsAsync() => await _context.Set<T>().ToListAsync();


        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(m => m.Id == id);
        public async Task UpdateActorAsync(int id, T entity)
        {
          EntityEntry entityEntry = _context.Entry(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
