using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachloopforsumofnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
