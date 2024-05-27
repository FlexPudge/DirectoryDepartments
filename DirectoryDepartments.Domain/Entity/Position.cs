using DirectoryDepartments.Domain.Interfaces;

namespace DirectoryDepartments.Domain.Entity
{
    public class Position : IEntityId<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
