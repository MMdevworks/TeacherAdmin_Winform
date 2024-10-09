using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAdmin_Winform
{
    class StudentGPAComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return y.GPA.CompareTo(x.GPA);
        }
    }
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public static List<Student> Data = new List<Student>();
    }
}
