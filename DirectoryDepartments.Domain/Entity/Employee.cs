namespace DirectoryDepartments.Domain.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int Gender { get; set; }
        public Position Position { get; set; }
        public int DriversLicense { get; set; }
        public Division Division { get; set; }
    }
}
