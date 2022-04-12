using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1900;

            if ((year%4==0 && year%100 !=0) || ((year%4==0 && (year%100 ==0)) && (year%400 ==0)))
            {
                Console.WriteLine("is a leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
    }
}
