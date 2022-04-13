using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            CNumber cn1 = new CNumber(20);
            CNumber cn2 = cn1;
            SNumber sn1 = new SNumber(20);
            SNumber sn2 = sn1;
            cn2.Value = 100;
            sn2.value = 100;

            Console.WriteLine(cn1);
            Console.WriteLine(sn1);
            Console.WriteLine(cn2);
            Console.WriteLine(sn2);
        }
    }
}
