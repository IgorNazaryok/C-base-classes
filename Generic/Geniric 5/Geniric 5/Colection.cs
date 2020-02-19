using System;
using System.Collections.Generic;
using System.Text;

namespace Geniric_5
{
    class MyCollection<T> where T : class
    {
        public MyCollection()
        {
            myCollection = new T[10];
        }

        private T[] myCollection;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }
        public T this[int index]
        {
            get { return myCollection[index]; }
            set { myCollection[index] = value; }
        }
        public void Add(T elem)
        {
            myCollection[count] = elem;
            count++;
        }
     
    }
}
