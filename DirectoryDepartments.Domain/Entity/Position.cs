﻿namespace DirectoryDepartments.Domain.Entity
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Employee>? Employee { get; set; }
    }
}
