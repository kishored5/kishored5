using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopforsumof_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int sum = 0;
            Array.ForEach(array, i => sum = 1);

            Console.WriteLine(sum);
        }
    }
}
