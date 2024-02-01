using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher student)
        {
            return new TeacherDto
            {
                Id=student.Id,
            };
        }

        public static Teacher ToTeacher(this TeacherDto studentdto) 
        {
            return new Teacher
            {
                Id = studentdto.Id,

            };
        }
    }

}
