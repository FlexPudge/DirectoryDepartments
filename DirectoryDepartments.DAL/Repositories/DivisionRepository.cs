using DirectoryDepartments.DAL.Repositories.BaseRepository;
using DirectoryDepartments.Domain.Entity;
using DirectoryDepartments.Domain.Interfaces.Repositories;

namespace DirectoryDepartments.DAL.Repositories
{
    public class DivisionRepository : BaseRepository<Employee>, IDivisionRepository
    {
        public DivisionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
