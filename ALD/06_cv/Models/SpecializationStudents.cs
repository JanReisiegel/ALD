using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cv.Models
{
    public class SpecializationStudents
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
                if(s1.StudentNumber % 2 == 0)
                {
                    if (s2.StudentNumber % 2 == 1)
                    {
                        return 1;
                    }
                }
                else if(s2.StudentNumber %2==0)
                {
                    return -1;
                }
                return s1.StudentNumber > s2.StudentNumber ? 1 : -1;
            });
        }

        public string PrintListOfStudents()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(SpecializationName+":");
            for(int i = 0; i < Students.Count; i++)
            {
                sb.AppendLine($"{i + 1, 2}: {Students[i].PrintStudent(SpecializationName)}");
            }
            return sb.ToString();
        }
    }
}
