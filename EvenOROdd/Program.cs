using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOROdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("\n{0} is a even number.\n", number);
            }
            else
            {
                Console.WriteLine("\n{0} is a odd number.\n", number);
            }
        }
    }
}
