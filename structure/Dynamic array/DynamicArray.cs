using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class DynamicArray < X >
    {
        X[] array;
        int size;
        int initialSize;

        public int Length { get { return size; } }
        public int Capacity { get { return array.Length; } }

        public DynamicArray (int size)
        {
            array = new X[size];
            initialSize = size;

        }

        public DynamicArray(params X[] values)
        {
            array = new X[values.Length];
            initialSize = values.Length;

            initialSize = values.Length;

            foreach (var value in values)
                Add(value);

        }
        public void Add(X value)
        {
            if (Length == Capacity)
                IncreaseSize();

            array[size++] = value;

        }

        private void IncreaseSize()
        {
            X[] newarray = new X[Capacity + initialSize];

            for (int i = 0; i < Capacity; i++)
                newarray[i] = array[i];

            array = newarray;
        }

        public void Insert (int pos,X value)
        {
            if (Capacity == size)
                IncreaseSize();

            for(int i = size; i >= pos; i--)
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

        public X this [int index]
        {
            get
            {
                if (index < 0 || index >=Length)
                    return default (X);
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
