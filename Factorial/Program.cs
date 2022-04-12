using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, num;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            f = 1;
            for (int i = 1; i <= num; i++)
            {
                f = f * i;
            }
            Console.Write("Factorial of : "+f);
        }
    }
}
