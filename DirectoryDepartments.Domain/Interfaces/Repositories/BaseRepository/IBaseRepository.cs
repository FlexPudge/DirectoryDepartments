namespace DirectoryDepartments.Domain.Interfaces.Repositories.BaseRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(object id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entityToUpdate);
        Task DeleteAsync(object id);
    }
}
