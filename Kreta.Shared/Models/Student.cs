using Kreta.Shared.Enums;

namespace Kreta.Shared.Models
{
    public class Student : IDbEntity<Student>
    {
        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
