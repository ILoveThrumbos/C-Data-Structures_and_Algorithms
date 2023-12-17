using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Bug_Testing1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("123", "Street St", "Suburb", "12345", "State");

            Console.WriteLine(address.ToString());

            Student student = new Student("mike", "mike@outlook.com", "0411111111", 1111, "me1", "04/11/2022");

            Console.WriteLine(student.ToString());

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int target = 7;
            int index = Utility.BinarySearch(numbers, target);

            Console.WriteLine("Target: " + target);
            Console.WriteLine("Index: " + index);


            Console.ReadKey();
        }
    }
}
