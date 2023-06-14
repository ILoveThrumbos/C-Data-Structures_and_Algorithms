using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using NUnit.Framework;
using System.Reflection;

namespace Test_MyLibrary
{
    [TestFixture]
    public class Test_MyLibrary
    {
        private List<Student> students;

        [SetUp]
        public void Setup()
        {
            // initiates students array list
            students = new List<Student>
            {
                new Student("Alice", "alice@outlook.com", "12345678", 123, "BSc", "01/01/2022"),
                new Student("Bob", "bob@outlook.com", "87654322", 456, "MSc", "02/02/2022"),
                new Student("Mary", "mary@outlook.com", "12345673", 888, "BSc", "01/01/2022"),
                new Student("Joe", "joe@outlook.com", "87654324", 777, "MSc", "03/02/2022"),
                new Student("Danny", "danny@outlook.com", "12345675", 666, "BSc", "01/01/2022"),
                new Student("Jack", "jack@outlook.com", "87654326", 555, "MSc", "04/02/2022"),
                new Student("Greg", "greg@outlook.com", "12345677", 111, "BSc", "05/01/2022"),
                new Student("Jane", "jane@outlook.com", "87654328", 222, "MSc", "06/02/2022"),
                new Student("Dorathy", "dorathy@outlook.com", "12345679", 333, "BSc", "01/01/2022"),
                new Student("Mike", "mike@outlook.com", "87654310", 444, "MSc", "07/02/2022"),
            };
        }

        /// <summary>
        /// Tests the LinearSearch method which returns index of found student
        /// </summary>
        [Test]
        public void LinearSearch_StudentFound_ReturnsIndex()
        {
            try
            {
                int index = Utility.SequentialSearch(students, students[0]);
                Assert.AreEqual(0, index, "Expected student not found at index 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Tests the BinarySearch method which returns index of found student
        /// </summary>
        [Test]
        public void BinarySearch_StudentFound_ReturnsIndex()
        {
            try
            {
                int index = Utility.BinarySearch(students, students[0]);
                Assert.AreEqual(5, index, "Expected student not found at index 5");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Tests the SortList method using Bubble sort 
        /// </summary>
        [Test]
        public void BubbleSort_SortsListInAscendingOrder()
        {
            try
            {
                Utility.SortList(students);

                for (int i = 0; i < students.Count - 1; i++)
                {
                    Assert.True(students[i].Name.CompareTo(students[i + 1].Name) <= 0,
                        "Expected student not found at index 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);

            }
        }

        /// <summary>
        /// Tests the InsertAtHead method adds a student at a head
        /// </summary>
        [Test]
        public void DoublyLinkedList_InsertAtHead_AddsStudentAtHead()
        {
            try
            {
                DoublyLinkedList<Student> list = new DoublyLinkedList<Student>();
                list.InsertAtHead(students[3]);

                Assert.AreEqual("Alice", list.head.Value.Name, "Expected student not added at the head");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);

            }
        }

        /// <summary>
        /// Tests the InsertAtTail method which adds a student at a tail
        /// </summary>
        [Test]
        public void DoublyLinkedList_InsertAtTail_AddsStudentAtTail()
        {
            try
            {
                DoublyLinkedList<Student> list = new DoublyLinkedList<Student>();
                list.InsertAtTail(students[1]);

                Assert.AreEqual("Bob", list.tail.Value.Name, "Expected student not added at the tail");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Tests the Find method which finds student from list
        /// </summary>
        [Test]
        public void DoublyLinkedList_Find_FindsExistingStudent()
        {
            try
            {
                DoublyLinkedList<Student> list = new DoublyLinkedList<Student>();
                list.InsertAtHead(students[1]);

                DoublyLinkedListNode<Student> foundNode = list.Find(students[1]);

                Assert.IsNotNull(foundNode, "Expected student not found in the list");
                Assert.AreEqual(students[0], foundNode.Value, "Found student does not match the expected student");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Tests the Delete method which removes student from list
        /// </summary>
        [Test]
        public void DoublyLinkedList_Delete_RemovesStudentFromList()
        {
            try
            {
                DoublyLinkedList<Student> list = new DoublyLinkedList<Student>();
                list.InsertAtHead(students[1]);

                list.Delete(list.head);

                Assert.IsNull(list.head, "Expected student not removed from the list");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }



    }
}
