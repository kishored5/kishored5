using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorwithswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, ans;
            string oper;
            Console.Write("Enter num1 = ");
            num1 = int.Parse(Console .ReadLine());
            Console.Write("Enter num2 = ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter oper (+,-,*,/) = ");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+": ans=num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = num1 / num2;
                    break;

                default:
                    ans = 0;
                    break;
            }
            Console.WriteLine("sum of numbers = "+ans);

        }
    }
}
