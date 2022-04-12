using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charectorORnumberORspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you Option : ");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());
            if ((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch>='0' && ch<='9')
            {
                Console.WriteLine(ch + " is an Number. ");
            }
            else
            {
                Console.WriteLine(ch + " is an Special Symbole. ");
            }
        }
    }
}
