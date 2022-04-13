using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInsertRemove();

            //TestObjectBasedGeneric();

            DynamicArray<int> numbers = new DynamicArray<int>(1, 2, 3, 4, 5);
            var names = new DynamicArray<string>("India", "uk", "usa");
            Console.WriteLine("Nummbers");
            for(int i=0;i<numbers .Length;i++)
                Console.WriteLine(numbers [i]*10);
            Console.WriteLine("Names");
            for(int i=0;i<names.Length;i++)
                Console.WriteLine(names[i].ToUpper());
        }
        private static void TestObjectBasedGeneric()
        {
            DynamicObjectArray numbers = new DynamicObjectArray(1, 2, 3, 4, 5);
            DynamicObjectArray names = new DynamicObjectArray("india", "usa", "uk", "france");

            numbers.Add("Hello World");
            names.Add(20);

            Console.WriteLine("Numbers");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("\nNames");
            for (int i=0; i < names.Length; i++)
                Console.WriteLine(names[i]);

        }

        private static void TestIndexer()
        {
            var list = new DynamicIntarray(5);
            Console.WriteLine($"{list}\tLength={list.Length }\tCapacity={list.capacity }");
            for (int i = 0; i < 15; i++)
            {
                list.Add(i);
                Console.WriteLine($"{list}");
            }

        }

        private static void TestInsertRemove()
        {
            var array = new DynamicIntarray(1, 2, 3, 5, 6, 7);
            array.Insert(3, 4);
            Console.WriteLine(array);

            array.Remove(4);
            Console.WriteLine(array);

            Console.WriteLine($"Array Length is {array.Length }");
            Console.WriteLine($"Arraay Capacity is {array.capacity}");

            for(var i=0;i<array.Length;i++)
                Console.WriteLine(array [i]);
        }
    }
}
