using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [5]; // one dimentional
            arr[0] = 10;
            arr[1] = 20;
            int[] arr1 = new int[4] { 10, 20, 30, 40 };
            int[] arr2 = new int[] { 10, 20, 30, 40 };

            int[,] arra = new int[2,3]; // two dimentional
            arra[0, 0] = 1;
            arra[0, 1] = 2;
            int[,] arra1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arra2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] array = new int [3][]; // three dimentional
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 1, 2 };
            array[2] = new int[4] { 1, 2 ,3 ,4};

            int[] list = new[] {4,5,6,7,6 }; // list 
            Console.WriteLine(arr[3]);
            Console.WriteLine(arra);
            Console.WriteLine(array);
            Console.WriteLine(list);
        }
    }
}
