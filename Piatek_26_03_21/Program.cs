using System;

namespace Piatek_26_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 11, 23, 25, 21, 2, 24, 100 };
            //Array.Sort(myArray);
            var binarySearch = new BinarySearch();
            int? index = binarySearch.Search(myArray, 11);
            Console.WriteLine(index);
        }
    }
}
