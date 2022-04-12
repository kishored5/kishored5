using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Program
    {

         double add(params double[] values)
        {
            double sum = 0;
            foreach (double value in values)
            {
                sum += value;
            }
            return sum;
        }
        static double sub(params double[] substa)
        {
            double subsum = 0;
            foreach (double subvalue in substa)
            {
                subsum-= subvalue;
            }
            return subsum;

        }

        static double mul(params double [] multi)
        {
            double mulsum = 1;
            for (int i = 0; i < multi.Length; i++)
            {
                mulsum *= multi.Length;
            }
            return mulsum;
        }

        double div (params double []divid)
        {
            double divsum = 1;
            for (int i = 1; i < divid.Length; i++)
            {
                divsum /= divid.Length;
            }
            return divsum;
        }
        private static void Main(string[] args)
        {
            Program p = new Program();

            double a = p.add(1, 2, 3, 4);
            double b = p.add(5, 9);
            double c = p.add(4, 2, 78, 4, 52, 32); //non static that why creating object "P"---program p= new program
            double d = p.add(1);
            double e = sub(2, 2);// given static in function
            double f = mul(2, 2);
            double g = p.div(2,3);

            Console.WriteLine(c);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);


        }
    }
}
    
