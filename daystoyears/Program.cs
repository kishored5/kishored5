using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daystoyears
{
    class Program
    {
        static void Main()
        {
            int years, weeks, days;
            Console.WriteLine("how many days:");
            days = Convert.ToInt32(Console.ReadLine());
            years = days / 365;
            
            weeks = (days % 365)/ 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years :"+years );
            Console.WriteLine("Weeks :" + weeks );
            Console.WriteLine("Days :" + days );
        }
    }
}
