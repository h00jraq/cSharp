using System;
using System.Linq;
namespace Piatek_26_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 5, 7, 11, 21, 23, 24, 25 , 100};
            //Array.Sort(myArray);
            
            var binarySearch = new BinarySearch();
            int? index = binarySearch.Search(myArray, 100);
            Console.WriteLine(index);
        }
    }
}
