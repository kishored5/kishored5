using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int[] arr = { 5,6,7,9,9};

            ///var sqaure = from int num in arr let sqrno = num * num select new {num,sqrno};
            int x = Convert.ToInt32(Console .ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sq = arr[x] * arr[y];
            ///foreach (var a in sqaure)
            {
                Console.WriteLine(sq);
            }
        }
    }
}
