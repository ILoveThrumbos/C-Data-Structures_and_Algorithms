using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    /// <summary>
    /// Represents a node in a doubly linked list.
    /// </summary>
    /// <typeparam name="T">The type of value stored in the node.</typeparam>
    public class DoublyLinkedListNode<T>
    {
        /// <summary>
        /// Gets or sets the previous node in the linked list.
        /// </summary>
        public DoublyLinkedListNode<T> Previous { get; set; }
        /// <summary>
        /// Gets or sets the next node in the linked list.
        /// </summary>
        public DoublyLinkedListNode<T> Next { get; set; }
        /// <summary>
        /// Gets or sets the value stored in the node.
        /// </summary>
        public T Value { get; set; }
    }

    /// <summary>
    /// Represents a doubly linked list.
    /// </summary>
    /// <typeparam name="T">The type of values stored in the linked list.</typeparam>
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> head;
        public DoublyLinkedListNode<T> tail;

        /// <summary>
        /// Inserts a new node with the specified value at the head of the linked list.
        /// </summary>
        /// <param name="value">The value to insert.</param>
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
        /// <summary>
        /// Inserts a new node with the specified value at the tail of the linked list.
        /// </summary>
        /// <param name="value">The value to insert.</param>
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
        /// <summary>
        /// Inserts a new node with the specified value after the specified node.
        /// </summary>
        /// <param name="node">The node after which to insert the new node.</param>
        /// <param name="value">The value to insert.</param>
        /// <exception cref="ArgumentNullException"> Thrown when the specified node is null</exception>
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

        /// <summary>
        /// Deletes the specified node from the linked list.
        /// </summary>
        /// <param name="node">The node to delete.</param>
        /// <exception cref="ArgumentNullException">Thrown when the specified node is null.</exception>
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

        /// <summary>
        /// Finds the first node with the specified value in the linked list.
        /// </summary>
        /// <param name="value">The value to find.</param>
        /// <returns>The first node with the specified value, or null if not found.</returns>
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
        /// <summary>
        /// Traverses the linked list and writes the values to the console.
        /// </summary>
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
