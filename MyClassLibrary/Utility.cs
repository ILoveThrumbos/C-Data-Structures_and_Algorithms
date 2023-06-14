using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    /// <summary>
    /// Provides utility methods for sorting and searching lists.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Sorts the elements in the list in ascending order.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to be sorted.</param>
        public static void SortList<T>(List<T> list) where T : IComparable<T>
        {
            list.Sort();
        }

        /// <summary>
        /// Sorts the elements in the list in descending order.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to be sorted.</param>
        public static void SortListDescending<T>(List<T> list) where T : IComparable<T>
        {
            list.Sort();
            list.Reverse();
        }

        /// <summary>
        /// Performs a binary search on the sorted list to locate the specified item.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The sorted list to search.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>The index of the item if found; otherwise, -1.</returns>
        public static int BinarySearch<T>(List<T> list, T item) where T : IComparable<T>
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = list[mid].CompareTo(item);

                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Performs a sequential search on the list to locate the specified item.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to search.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>The index of the item if found; otherwise, -1.</returns>
        public static int SequentialSearch<T>(List<T> list, T item) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

