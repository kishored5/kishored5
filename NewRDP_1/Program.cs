using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRDP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            checkedinevenornot(num);
            
        }

        private static void checkedinevenornot(int num)
        {
            if (num % 2==0)
            {
                Console.WriteLine(num+" Its a even number.");
            }
            else
            {
                Console.WriteLine(num+" Its an odd number.");
            }
        }
    }
}
