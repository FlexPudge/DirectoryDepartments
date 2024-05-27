namespace DirectoryDepartments.Domain.Interfaces
{
    public class IEntityId<T> where T : struct
    {
        public T Id { get; set; }
    }
}
