using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class ParentExtension
    {
        public static ParentDto ToParentDto(this Parent student)
        {
            return new ParentDto
            {
                Id=student.Id,
            };
        }

        public static Parent ToParent(this ParentDto studentdto) 
        {
            return new Parent
            {
                Id = studentdto.Id,
            };
        }
    }

}
