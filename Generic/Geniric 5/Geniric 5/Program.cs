using System;

namespace Geniric_5
{
    class Program
    {

        static void Main(string[] args)
        {
            MyCollection<Car> myList = new MyCollection<Car>();
            myList.Add(new Car("AMG", "1993"));
            myList.Add(new Car("Ford", "2001"));
            myList.Add(new Car("Tesla", "2016"));
            for (int i = 0; i < myList.Count; i++)
            {
                myList[i].print();
            }

            Console.WriteLine("Кол-во элементов: " + myList.Count);
            
        }
    }
}
