using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_cv.Models
{
    internal class SortStudent
    {
        public int Count { get; private set; }
        public SortStudent() { }

        public List<Student> SortStudents(List<Student> list)
        {
            list.Sort((Student s1, Student s2) =>
            {
                if (s1.StudentNumber.CompareTo(s2.StudentNumber) <= 0)
                {
                    return 1;
                }
                else { return 0; }
            });
            return list;
        }

        
    }
}
