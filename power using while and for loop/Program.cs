using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_using_while_and_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int basenumber, exponentnumber, power, i;
            Console.Write("Enter base number : ");
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter exponentnumber number : ");
            exponentnumber = Convert.ToInt32(Console.ReadLine());
            power = 1;

            i = 1;
            while (i<=exponentnumber)
            {
                power = power * basenumber;
                i++;
            }
            Console.WriteLine("Power : "+power);

            /*for (i = 1; i <= exponentnumber; i++)
            {
                power = power * basenumber ;
            }
            Console.WriteLine("Power : " + power);*/

        }
    }
}
