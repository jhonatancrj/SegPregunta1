using System;
using StudentApp.Business;

namespace StudentApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            var students = studentService.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Nombre: {student.Name}, Edad: {student.Age}");
            }
        }
    }
}
