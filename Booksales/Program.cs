using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = "god";
            string author = "krishna";
            int price = 500;
            int rating = 2;
            if (price <= 400 && rating <= 5)
            {
                Console.WriteLine("you must read it {0} {1}", book, author);
            }
            else if (price >= 400 && rating <= 4)
            {
                Console.WriteLine("Ones you read it {0} {1}", book, author);
            }
        }
    }
}
