using Student_System.DataAccess;
using System.Collections.Generic;

namespace Student_System.Services
{
    public interface IStudentService
    {
        public void AddStudent(Student studenttoAdd);

        public  List<Student> GetStudents();

        public List<Student> ExcellentStudents();

        Student GetById(int id);

        void EditStudent(Student student);

        void DeleteStudent(int id);
    }
}
