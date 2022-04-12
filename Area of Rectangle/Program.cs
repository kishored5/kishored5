using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length,width, Area;
            Console.Write("Length of rectangle = ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width of rectangle = ");
            width  = Convert.ToDouble(Console.ReadLine());
            Area = length *width ;
            Console.WriteLine("\nArea of recangle = {0}",Area);
        }
    }
}
