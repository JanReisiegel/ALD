using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_cv.Models
{
    internal class Student
    {
        public Student(string studentNumber, string firstName, string lastName, DateTime birthDate)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public override string ToString()
        {
            return $"{StudentNumber}\t{FirstName} {LastName}\t{BirthDate}";
        }
    }
}
