using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_7
{
    class MyList
    {
        private object[] array;

        public MyList()
        {
            array = new object[0];
        }

        public void PrintElement()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public int Add(object value)
        {
            object[] tmp = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tmp[i] = array[i];
            }
            tmp[tmp.Length - 1] = value;
            array = tmp;
            return tmp.Length - 1;
        }

        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(object value)
        {
            return IndexOf(value, 0);
        }

        public int IndexOf(object value, int startIndex)
        {
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(object value)
        {
            if (!Contains(value))
            {
                return;
            }
            object[] tmp = new object[array.Length - 1];
            bool deleted = false;
            for (int i = 0, j = 0; i < tmp.Length; i++, j++)
            {
                if (array[i].Equals(value) && !deleted)
                {
                    j++;
                    deleted = true;
                }
                tmp[i] = array[j];
            }
            array = tmp;
        }

        public void Insert(int index, object value)
        {
            object[] tmp = new object[array.Length + 1];
            if (index - 1 >= array.Length + 1 || index < 0)
            {
                Console.WriteLine("Элемент не найден!");
                return;
            }
            for (int i = 0, j = 0; i < tmp.Length && j < array.Length; i++, j++)
            {
                if (j == index - 1)
                {
                    tmp[j] = value;
                    i++;
                }

                tmp[tmp.Length - 1] = value;
                tmp[i] = array[j];
            }
            array = tmp;
        }
        public void RemoveAt(int index)
        {
            if (index >= array.Length || index < 0)
            {
                Console.WriteLine("Выход за пределы списка");
                return;
            }
            object[] tmp = new object[array.Length - 1];
            for (int i = 0, j = 0; i < tmp.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                tmp[i] = array[j];
            }
            array = tmp;
        }


        public void Clear()
        {
            array = new object[0];
        }


        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

    }
}
