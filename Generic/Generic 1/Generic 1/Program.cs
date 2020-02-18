using System;

namespace Generic_1
{
    public class MyClass <T> where T : new()
    {
       public  static T FactoryMetod() 
        {            
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<int>.FactoryMetod());
            Console.WriteLine(MyClass<bool>.FactoryMetod());
        }
    }
}
