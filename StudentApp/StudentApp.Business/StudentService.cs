using System.Collections.Generic;
using StudentApp.Data;

namespace StudentApp.Business
{
    public class StudentService
    {
        private readonly StudentRepository _repository;

        public StudentService()
        {
            _repository = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return _repository.GetAllStudents();
        }
    }
}
