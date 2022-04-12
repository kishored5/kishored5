using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lengthofarray
{
    class Program
    {
        static void Main()
        {
            int[] Arr = { 20, -10, -30, 0, 15, 10, 30 };
            Console.WriteLine("Maximum Element : " + Arr.Max());
            Console.WriteLine("Minimum Element : " + Arr.Min());
            Console.Read();
        }
    }
}
