using DirectoryDepartments.DAL.Repositories.BaseRepository;
using DirectoryDepartments.Domain.Entity;
using DirectoryDepartments.Domain.Interfaces.Repositories;

namespace DirectoryDepartments.DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
