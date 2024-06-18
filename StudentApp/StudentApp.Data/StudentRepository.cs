using System.Collections.Generic;

namespace StudentApp.Data
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            // En un caso real, este método interactuaría con la base de datos.
            return new List<Student>
            {
                new Student { Id = 1, Name = "Juan Pérez", Age = 20 },
                new Student { Id = 2, Name = "Ana Gómez", Age = 22 }
            };
        }
    }
}
