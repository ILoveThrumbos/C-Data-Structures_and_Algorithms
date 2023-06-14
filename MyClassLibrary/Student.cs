using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Student: Person, IComparable<Student>
    {
        public int Id;
        public string Program;
        public string Date_Registered;
        public Enrollment _Enrollment;

        public Student(string _name, string _email, string _telnum, int _id, string _program, string _dateRegistered)
                                    :base(_name,_email, _telnum)
        {
            Id = _id;
            Program = _program;
            Date_Registered = _dateRegistered;


        }

        public void setEnrollment(string _dateEnrolled, string _grade, string _semester, Course _course)
        {
            _Enrollment = new Enrollment(_dateEnrolled, _grade, _semester, _course);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                /*
                 * Both the Id and Program is chosen as they're unique identifiers.
                 * This means there will be less likely a collisions (two objects with the same hash code) which will
                 * improve the overall sort and searching operations.
                 */
                int hash = 17;
                hash = hash * 23 + Id.GetHashCode();       // Hashing the 'Id' string varible
                hash = hash * 23 + Program.GetHashCode();  // Hashing the 'Program' string varible
                return hash;
            }
        }
        public int CompareTo(Student other)
        {
            if (other == null)
                return 1;

            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return base.ToString() + "" + Id + " " +  Program + " " + Date_Registered;
        }
    }
}
