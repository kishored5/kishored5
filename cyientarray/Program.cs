using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyientarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                names[i]= Convert.ToString(Console .ReadLine());
            }
            Console.WriteLine("\n\n Displaying names");
            /*for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }*/
            foreach (var name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
        }
    }
}
