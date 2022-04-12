using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundIntrest
{
    class Program
    {
        static void Main(string[] args)
        {
            float amount, intrest, rate,time,ci,k;
            Console.WriteLine("Enter your amount : ");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your intrest rate : ");
            rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your time : ");
            time = float.Parse(Console.ReadLine());

            intrest = 1 + (rate / 100);
            ci = 1;
            for (k = 1; k <= time; k++)
            ci = ci * intrest;
            ci = amount * ci - amount;
            Console.WriteLine("Your compound interest is : " + ci);
            Console.ReadLine();
        }
    }
}
