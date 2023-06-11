using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestMyLib
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Person object");
            Person p1 = new Person("John", "john@outlook.com", "05454545");
            p1.setAddress("23", "Sea Street", "Brighton", "4312", "SA");
            Console.WriteLine(p1);

            Console.WriteLine("Testing Student object");
            Student s1 = new Student("Mike", "mike@outlook.com", "05434545", "Dip SD", "10/10/2021");
            s1.setAddress("23", "Monkey Street", "Brighton", "4312", "SA");
            Console.WriteLine(s1);

        }
    }
}
