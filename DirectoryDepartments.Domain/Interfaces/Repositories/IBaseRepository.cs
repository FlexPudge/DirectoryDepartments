namespace DirectoryDepartments.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<IEntity>
    {
        IEnumerable<IEntity> GetAll();

        Task<IEntity> CreateAsync(IEntity entity);

        IEntity Update(IEntity entity);

        void Remove(IEntity entity);

        Task<int> SaveChangesAsync();
    }
}
