using DirectoryDepartments.DAL.Repositories.BaseRepository;
using DirectoryDepartments.Domain.Entity;
using DirectoryDepartments.Domain.Interfaces.Repositories;

namespace DirectoryDepartments.DAL.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
