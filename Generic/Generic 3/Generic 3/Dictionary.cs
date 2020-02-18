using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_3
{
    public class Dictionary<T_key, T_value>
    {
        private T_key[] myKey = new T_key[10];
        private T_value[] myValue = new T_value[10];


        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public T_key this[int index]
        {
            get
            {
                return myKey[index];

            }
            set
            {
                myKey[index] = value;

            }
        }

        public T_value this[T_key index]
        {
            get
            {
                for (int i = 0; i < count; i++)
                    if (index.Equals(myKey[i]))
                        return myValue[i];
                return myValue[count];
            }

        }

        public void Add(T_key key, T_value value)
        {
            myKey[count] = key;
            myValue[count] = value;
            count++;
        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myKey[i] + " " + myValue[i]);
            }
        }

    }
}
