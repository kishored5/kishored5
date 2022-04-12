using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fact;
            Console.Write("number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            fact = factorial(num);
            Console.Write("Factorial of {0} : " + fact,num);
            Console.ReadLine();
        }

        private static int factorial(int i)
        {
            
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
            
        }
    }
}
