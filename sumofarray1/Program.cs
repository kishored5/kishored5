using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofarray
{
    class Program
    {
        static void Main()
        {
            /*int[] arr = new int[10];
            int num, sum = 0;
            Console.Write("Enter size of array : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter array numbers : ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of num = "+sum);*/

            int[] arr = new int[10];
            int size, num, position;
            Console.Write("Enter size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter array numbers : ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter insert numbers : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter position of array : ");
            position = Convert.ToInt32(Console.ReadLine());

            if (position > size + 1 || position <= 0)
            {
                Console.WriteLine("Invalid position! Please enter position between 1 to " + size);
            }
            else
            {
                for (int i = size; i >= position; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[position - 1] = num;
                size++;
            }
            Console.WriteLine("Array elements after insertion :");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
    }
}
