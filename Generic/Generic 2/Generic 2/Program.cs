using System;

namespace Generic_2
{
    static class Program
    {

        public static T[] GetArray<T>(this List<T> list)
        {
            T[] array = new T[5];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        static void Main(string[] args)
        {
            
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(3);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList.Count);
          
        }
    }
}