using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    public class Student
    {
        public char StudentSpec {  get; set; }
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string studentNumber, string firstName, string lastName)
        {
            StudentSpec = studentNumber.First();
            StudentNumber = Int32.Parse(studentNumber.Remove(0, 1));
            FirstName = firstName;
            LastName = lastName;
        }

        public string PrintStudent(string specialization)
        {
            return $"{StudentSpec} {LastName.ToUpper()+" "+FirstName, -18} {specialization, -3} {StudentNumber}";
        }
    }
}
