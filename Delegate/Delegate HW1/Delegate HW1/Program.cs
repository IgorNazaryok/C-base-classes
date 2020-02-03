using System;

namespace Delegate_HW1
{
    public delegate double Average(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            Average myAver = delegate (int a, int b, int c) { return ((a + b + c) / 3); };
            
            Console.WriteLine(myAver.Invoke(1, 2, 3));
        }
    }
}
