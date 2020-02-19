using System;

namespace Generic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList aList = new MyList();
            aList.Add(3);
            aList.Add(5);
            Console.WriteLine("Количество элементов  ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.Insert(2, 9);
            Console.WriteLine("Количество элементов после insert(ставка элемента перед элементом с индексом 2) ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.RemoveAt(0);
            Console.WriteLine("Количество элементов после удаления 0-элемента  ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.Remove(4);
            Console.WriteLine("Количество элементов после удаления элемента равного 4  ArrayList:" + aList.Count);
            aList.PrintElement();

            aList.Clear();
            Console.WriteLine("Количество элементов после выполнения clear() ArrayList:" + aList.Count);

        }
    }
}
