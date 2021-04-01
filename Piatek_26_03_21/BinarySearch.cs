using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatek_26_03_21
{
    public class BinarySearch
    {

        public int? Search(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            /* {
                int middle = (left + right) / 2;
                if (value == array[middle])
                    return middle;
                else if ((value > array[array.Length-1] || value < array[left]))
                    break;
                else if (value < array[middle])
                    right = middle;
                else if (value > array[middle])
                {
                    left = middle;
                    right = array.Length;
                }

            } */
            {
                int middle = (left + right) / 2;
                if (value == array[middle]) 
                    return middle;
                if (value < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;

            }
            return null;
        }
    }
}
