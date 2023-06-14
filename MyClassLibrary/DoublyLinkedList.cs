using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
    }

    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> head;
        public DoublyLinkedListNode<T> tail;

        public void InsertAtHead(T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>
            {
                Value = value,
                Next = head
            };

            if (head != null)
                head.Previous = newNode;
            else
                tail = newNode;

            head = newNode;
        }

        public void InsertAtTail(T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>
            {
                Value = value,
                Previous = tail
            };

            if (tail != null)
                tail.Next = newNode;
            else
                head = newNode;

            tail = newNode;
        }

        public void InsertAfter(DoublyLinkedListNode<T> node, T value)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>
            {
                Value = value,
                Previous = node,
                Next = node.Next
            };

            if (node.Next != null)
                node.Next.Previous = newNode;
            else
                tail = newNode;

            node.Next = newNode;
        }

        public void Delete(DoublyLinkedListNode<T> node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            if (node.Previous != null)
                node.Previous.Next = node.Next;
            else
                head = node.Next;

            if (node.Next != null)
                node.Next.Previous = node.Previous;
            else
                tail = node.Previous;
        }

        public DoublyLinkedListNode<T> Find(T value)
        {
            DoublyLinkedListNode<T> currentNode = head;

            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                    return currentNode;

                currentNode = currentNode.Next;
            }

            return null;
        }

        public void Traverse()
        {
            DoublyLinkedListNode<T> currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);

                currentNode = currentNode.Next;
            }
        }

    }
}
