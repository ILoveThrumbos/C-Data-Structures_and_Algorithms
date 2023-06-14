using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public static class Utility
    {
        public static void SortList<T>(List<T> list) where T : IComparable<T>
        {
            list.Sort();
        }

        public static void SortListDescending<T>(List<T> list) where T : IComparable<T>
        {
            list.Sort();
            list.Reverse();
        }


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

