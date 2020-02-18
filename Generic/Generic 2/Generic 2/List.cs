using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_2
{
    public class List<T>
    {
        public List()
        {
            list = new T[5];
        }

        T[] list;
        int count = 0;

        public int Count
        {
            get { return count; }
        }
        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public void Add(T value)
        {
            list[count] = value;
            count++;
        }
    }
}
