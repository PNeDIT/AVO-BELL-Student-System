using Student_System.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Student_System.Services
{
    public class StudentService: IStudentService
    {
    private readonly ApplicationDbContext db;

    public StudentService(ApplicationDbContext db)
    {
            this.db = db;
    }

        public void AddStudent(Student studenttoAdd)
        {
            db.Students.Add(studenttoAdd);

            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var studentToDelete = this.GetById(id);
            this.db.Students.Remove(studentToDelete);

            db.SaveChanges();
        }

        public void EditStudent(Student _student)
        {
            var student = this.GetById(_student.Id);

            student.FirstName = _student.FirstName;
            student.LastName = _student.LastName;
            student.Class = _student.Class;
            student.AvgSuccess = _student.AvgSuccess;
            student.DateOfBirth = _student.DateOfBirth;

            db.SaveChanges();
        }

        public List<Student> ExcellentStudents()
        {
            return db.Students.ToList();
        }

        public Student GetById(int id)
        {
            return this.db.Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
    }
}
