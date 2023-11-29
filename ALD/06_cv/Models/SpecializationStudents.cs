using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    internal class SpecializationStudents
    {
        public string SpecializationName {  get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public SpecializationStudents(string specializationName)
        {
            SpecializationName = specializationName;
        }

        public void PutStudent(Student student)
        {
            Students.Add(student);
            Students.Sort((Student s1, Student s2) =>
            {
                if (s1.StudentNumber % 2 == 1 && s2.StudentNumber % 2 == 0)
                {
                    return 1;
                }
                else if (s1.StudentNumber.CompareTo(s2.StudentNumber) <= 0)
                {
                    return 1;
                }
                else { return 0; }
            });
        }

        public string PrintListOfStudents()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(SpecializationName);
            foreach (Student student in Students)
            {
                student.PrintStudent(SpecializationName);
            }
            return sb.ToString();
        }
    }
}
