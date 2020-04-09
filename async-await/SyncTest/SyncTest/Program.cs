using System;
using System.Threading.Tasks;
using System.Threading;

namespace HelloApp
{
    class Program
    {
        static void Factorial(int n)
        {
            Console.WriteLine("Начата загрузка файла {0} файла", n);          
            Thread.Sleep(3000);
            Console.WriteLine("Загрузка файла {0} завершена", n);
        }


        static void Main(string[] args)
        {

            DateTime start = DateTime.Now;
            for (int i = 1; i <= 4; i++)
            {
                Factorial(i);
            }
            TimeSpan time = DateTime.Now - start;
            Console.WriteLine("Время загрузки {0} файлов {1} минут, {2} секунд, {3} милисекунд", 4, time.Minutes, time.Seconds, time.Milliseconds);


        }    
    }
}
