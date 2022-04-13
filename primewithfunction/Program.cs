using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primewithfunction
{
    class Program
    {
        public static bool checkprime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter any number :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (checkprime(n))
                Console.WriteLine(n + " Is a prime.");
            else
                Console.WriteLine(n + " not a prime.");

        }

        
    }
}
