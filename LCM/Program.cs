using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num1, num2,lcm=0;
            Console.WriteLine("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            num = num1 * num2;

            while (num1!=num2)
            {
                if (num1>num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (num)/num1;
            Console.Write("Least Common Multiple is : " + lcm);

            Console.ReadLine();

        }
    }
}
