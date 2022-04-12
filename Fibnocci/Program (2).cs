using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnocci
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibnocci series : " );
            for (int i = 0; i < num; i++)
            {
                Console.Write(Fibnocciseries (i)+"\t");
            }
            Console.ReadLine();
        }

        public static int Fibnocciseries(int num)
        {
            int n1=0, n2=1,temp;
            for (int i = 0; i < num; i++)
            {
                temp = n1;
                n1 = n2;
                n2 = temp+n2;
            }
            return n1;

        }
    }
}
