using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class DynamicObjectArray
    {
        object[] array;
        int size;
        int initialSize;

        public int Length { get { return size; } }
        public int Capacity { get { return array.Length; } }


        public DynamicObjectArray(int size)
        {
            array = new string[size];
            initialSize = size;
        }

        public DynamicObjectArray (params object [] values)
        {
            array = new object[values.Length];
            initialSize = values.Length;

            initialSize = values.Length;
            foreach (var value in values)
                Add(value);

        }

        public void Add (object value)
        {
            if (Length == Capacity)
                IncreaseSize();
            array[size++] = value;
        }

        public void IncreaseSize()
        {
            Object[] newArray = new object[Capacity + initialSize];
            for (int i = 0; i < Capacity; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        public void Insert(int pos,object value)
        {
            if (Capacity == size)
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
            for(int i=pos;i<size;i++)
            {
                array[i] = array[i + 1];

            }
            size--;
        }

        public object this [int index]
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
