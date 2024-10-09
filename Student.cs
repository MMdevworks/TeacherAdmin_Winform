using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAdmin_Winform
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public static List<Student> Data = new List<Student>();
    }
}
