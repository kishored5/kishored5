using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, min, hcf=0,i;
            Console.WriteLine("Enter any number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            min = (num1 < num2) ? num1 : num2;
            for (i = 1; i <=min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf=i;
                }
            }
            Console.WriteLine("HCF of " + num1 + " and " + num2 + " is : " + hcf);
            Console.ReadLine();
        }
    }
}
