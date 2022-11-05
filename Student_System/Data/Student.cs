using System;

namespace Student_System.DataAccess
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Class { get; set; }

        public double AvgSuccess { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
