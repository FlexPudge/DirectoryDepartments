using DirectoryDepartments.Domain.Interfaces;

namespace DirectoryDepartments.Domain.Entity
{
    public class Division : IEntityId<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfFormation { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public Division ParentDivision { get; set; }
        public ICollection<Division> SubsidiaryDivisions { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
