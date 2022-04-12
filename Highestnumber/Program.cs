using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num, num1, num2;
            Console.Write("Enter num value :");
             num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num1 value :");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2 value :");
             num2 = Convert.ToInt32(Console.ReadLine());

            if (num >= num1 && num >= num2)
            {
                Console.WriteLine("Hiest number : {0}.", num);
            }
            else if (num1 >= num2 && num1 >= num) 
            {
               Console.WriteLine("Hiest number : {0}.", num1);
            }
            else
            {
               Console.WriteLine("Hiest number : {0}.", num2);
            }*/

            int num1, num2, num3, largest;

            Console.WriteLine("Enter three numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());


            largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

            Console.WriteLine(largest + " is the largest number.");

            Console.ReadLine();

        }

    }
}

