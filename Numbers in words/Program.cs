using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_words
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num=0;
            Console.Write("Enter any number : ");
            i = Convert.ToInt32(Console.ReadLine());

            while (i!=0)
            {
                num =(num*10)+(i % 10);
                i /= 10;
            }
            while (num != 0)
            {

                switch (num % 10)
                {
                    case 0:
                        Console.Write("Zero ");
                        break;
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                }
                num = num / 10;
            }
            Console.ReadLine();
        }
    }
}
