using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class DynamicStringArray
    {
        string[] array;
        int size;
        int initialSize;

        public int Length { get { return size; } }
        public int Capacity { get { return array.Length; } }

        public DynamicStringArray(int size)
        {
            array = new string[size];
            initialSize = size;
        }

        public DynamicStringArray(params string[] values)
        {
            array = new string[values.Length];
            initialSize = values.Length;

            initialSize = values.Length;
            foreach (var value in values)
                Add(value);

        }

        public void Add(string value)
        {
            if(Length == Capacity)
            IncreaseSize();
            array[size++] = value;

        }

        public void IncreaseSize()
        {
            string [] newArray = new string[Capacity + initialSize];
            for (int i = 0; i < Capacity; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        public void Insert(int pos,string value)
        {
            if (Capacity == size)
                IncreaseSize();

            for(int i=size-1;i>=pos;i--)
            {
                array[i + 1] = array[i];
            }
            array[pos] = value;
            size++;

        }

        public void Remove(int pos)
        {
            for(int i=pos;i<size;i++)
            {
                array[i] = array[i + 1];

            }
            size--;

        }

        public string this [int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    return null;
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
            var str = "DynamicArray" + (Length == Capacity ? "[\t" : "(\t");

            for (int i = 0; i < Length; i++)
                str += $"{array[i]}\t";

            str += Length == Capacity ? "]" : ")";
            return str;
        }
    }
}
