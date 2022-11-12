using Core.Persistence.Repositories;

namespace OwlSchool.Domain.Entities
{
    public class Class : Entity
    {
        public Class()
        {
        }

        public Class(string name, int floor) : this()
        {
            Name = name;
            Floor = floor;
        }

        public string Name { get; set; }
        public int Floor { get; set; }
    }
}