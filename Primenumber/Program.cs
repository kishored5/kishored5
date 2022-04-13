using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, f, i;
            Console.Write("Enter any number : ");
            num = Convert.ToInt32(Console .ReadLine());
            f = 0;
            for (i = 2; i <= num/2 ; i++)
            {
                if (num % i == 0)
                {
                    f = 1;
                    break;
                }
            }
            if (f==0)
            {
                Console.WriteLine("{0} is a prime number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.",num);
                
            }
        }
    }
}
