using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Course : IComparable<Course>
    {
        public string CourseCode;
        public string CourseName;
        public decimal Cost;

        public Course(string _courseCode, string _courseName, decimal _cost)
        {
            CourseCode = _courseCode;
            CourseName = _courseName;
            Cost = _cost;
        }

        public override string ToString()
        {
            return base.ToString() + "" + CourseCode + " " + CourseName + " " + Cost;
        }

        public int CompareTo(Course other)
        {
            throw new NotImplementedException();

        }
    }
}
