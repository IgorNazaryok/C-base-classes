using System;

namespace Generic_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Dictionary<int, string> NumberToString = new Dictionary<int, string>();
            NumberToString.Add(1, "один");
            NumberToString.Add(2, "два");
            NumberToString.Add(3, "три");
            NumberToString.Add(4, "четыре");
            NumberToString.Add(5, "пять");
            NumberToString.Add(6, "шесть");

            Console.WriteLine( NumberToString[NumberToString[0]] ); 
           // NumberToString.print();

        }
    }
}
