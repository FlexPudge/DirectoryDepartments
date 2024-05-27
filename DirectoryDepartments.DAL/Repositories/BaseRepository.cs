using DirectoryDepartments.Domain.Interfaces.Repositories;

namespace DirectoryDepartments.DAL.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Пустой объект");
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Remove(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Пустой объект");
            _context.Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Пустой объект");
            _context.Update(entity);
            return entity;
        }
    }
}
