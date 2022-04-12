using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] years = { 2000, 1987, 2020 };
            DateTimeFormatInfo kkd = DateTimeFormatInfo.CurrentInfo;
            Console.WriteLine("{0,-10}{1,-15}{2,4}\n","year","Month","Days");
           
            foreach (var year in years)
            {
                for (int i = 0; i < kkd.MonthNames.Length-1;i++)
                {
                    Console.WriteLine("{0,-10}{1,-15}{2,4}",year,kkd.MonthNames[i],DateTime.DaysInMonth(year, i+1));
                }
                Console.WriteLine();
            }
            
        }
    }
}
