using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agreegatefor_sumof_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int sum = array.Aggregate((total, next) => total + next);
            Console.WriteLine(sum);
        }
    }
}
