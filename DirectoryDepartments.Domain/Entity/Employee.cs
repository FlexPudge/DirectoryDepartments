using DirectoryDepartments.Domain.Interfaces;

namespace DirectoryDepartments.Domain.Entity
{
    public class Employee : IEntityId<int>
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Gender { get; set; }
        public Position Position { get; set; }
        public bool DriversLicense { get; set; }
    }
}
