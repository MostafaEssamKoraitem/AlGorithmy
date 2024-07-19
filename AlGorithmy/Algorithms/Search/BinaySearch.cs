using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlGorithmy.Algorithms.Search
{
    public partial class AlGorithmy
    {
        // Binary Search for an array of integers
        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    return mid;
                }
                if (array[mid] < key)
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

        // Binary Search for a list of integers
        public static int BinarySearch(List<int> list, int key)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (list[mid] == key)
                {
                    return mid;
                }
                if (list[mid] < key)
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

        // Binary Search for a custom type with a custom comparison
        public static int BinarySearch<T>(T[] array, T key, Comparison<T> comparison)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int cmp = comparison(array[mid], key);
                if (cmp == 0)
                {
                    return mid;
                }
                if (cmp < 0)
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

        // Binary Search for a generic type implementing IComparable
        public static int BinarySearch<T>(T[] array, T key) where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int cmp = array[mid].CompareTo(key);
                if (cmp == 0)
                {
                    return mid;
                }
                if (cmp < 0)
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
    }
}
