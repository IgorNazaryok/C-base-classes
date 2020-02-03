using System;

namespace Delegate_HW3
{
    public delegate int Delegat();
    public delegate int Delegate(Delegat[] mas);
    class Program
    {
        const int n = 5;
        private static int Average(Delegat[] m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {              
                sum += m[i].Invoke();
                Console.WriteLine(m[i].Invoke());
            }
            return sum / n;
        }
        private static int ReturnValue()
        {
            Random rm = new Random();
            int rm_value = rm.Next(1, 5);           
            return rm_value;
        }


        static void Main(string[] args)
        {
            Delegat[] mas = new Delegat[n]; //масив делегатов
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Delegat(ReturnValue);                
            }

            Delegate sum = new Delegate(Average);
            Console.WriteLine("Average:" + sum.Invoke(mas));
        }
    }
}