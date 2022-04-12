using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender
{
    class Program
    {
        static void Main(string[] args)
        {
            int feb = 2;

            int days = DateTime.DaysInMonth(1991, feb);
            Console.WriteLine("1991 FEB = {0}", days);

        }
    }
}
