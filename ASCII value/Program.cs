using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_value
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Enter your char: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII value of " + c +" "+Convert.ToInt32(c));
        }
    }
}
