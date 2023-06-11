using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Enrollment
    {
        public string Date_Enrolled;
        public string Grade;
        public string Semester;
        public Course Course;

        public Enrollment(string _dateEnrolled, string _grade, string _semester, Course _course)
        {
            Date_Enrolled = _dateEnrolled;
            Grade = _grade;
            Semester = _semester;
            Course = _course;
        }


        public override string ToString()
        {
            return base.ToString() + "" + Date_Enrolled + " " + Grade + " " + Semester;
        }
    }
}
