using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnocci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers: ");
            int n = (int)Convert.ToDouble(Console.ReadLine());
            int num = n - 1;
            int[] fib = new int[num + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
                Console.Write("{0}\t", fib[i]);
            }
            
        }

    }
}
