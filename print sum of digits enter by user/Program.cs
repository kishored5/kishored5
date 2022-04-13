using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_sum_of_digits_enter_by_user
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, total;
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (total = 0; num > 0; num = num / 10)

            total = total + (num % 10);
            {
                Console.WriteLine("Sum of digits: " + total);
            }
        }
    }
}
