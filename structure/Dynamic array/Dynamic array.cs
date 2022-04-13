using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class DynamicIntarray
    {
        int[] array;
        int size;
        int initialsize;

        public int Length { get { return size; } }
        public int capacity { get { return array.Length; } }
        
        public DynamicIntarray(int size)
        {
            array = new int[size];
            initialsize = size;
        }

        public DynamicIntarray(params int[]values)
        {
            array = new int [values.Length];
            initialsize = values.Length;

            initialsize = values.Length;
            foreach (var value in values)
                Add(value);

        }

        public void Add(int value)
        {
            if (Length == capacity)
                IncreaseSize();
            array[size++] = value;

        }

        public void IncreaseSize()
        {
            //You can't increase array size. Youc an only create new bigger array
            int[] newarray = new int[capacity + initialsize];

            for (int i = 0; i < capacity; i++)
                newarray[i] = array[i];
            array = newarray;

        }
        public void Insert(int pos, int value)
        {
            if (capacity == size)
                IncreaseSize();

            for(int i=size;i>=pos;i--)
            {
                array[i + 1] = array[i];

            }

            array[pos] = value;
            size++;

        }

        public void Remove(int pos)
        {
            for (int i = pos; i < size; i++)
            {
                array [i] = array[i + 1];
            }
            size--;

        }


        public int this [int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    return 0;
                return array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                    return;
                array[index] = value;
            }

        }
        public override string ToString()
        {
            if (Length == 0)
                return "DynamicArray(empty)";
            var str = "DynamicArray" + (Length == capacity ? "[\t" : "(\t");

            for (int i = 0; i < Length; i++)
                str += $"{array[i]}";

            str += Length == capacity ? "]" : ")";

            return str;
        }
    }
}
