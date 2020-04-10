using System;
using System.Threading.Tasks;
using System.Threading;

namespace HelloApp
{
    class Program
    {
        static void FileUpload(int n)
        {
            Console.WriteLine("Начата загрузка файла {0} файла",n);         
            Thread.Sleep(3000);            
            Console.WriteLine("Загрузка файла {0} завершена", n);
        }
       
        static async void FileUploadAsync(int n)
        {
            DateTime start = DateTime.Now;
            Task t1 = Task.Run(() => FileUpload(1));
            Task t2 = Task.Run(() => FileUpload(2));
            Task t3 = Task.Run(() => FileUpload(3));
            Task t4 = Task.Run(() => FileUpload(4));
            await Task.WhenAll(new[] { t1, t2, t3, t4 });
            TimeSpan time = DateTime.Now- start;
            Console.WriteLine("Время загрузки {0} файлов {1} минут, {2} секунд, {3} милисекунд", 4, time.Minutes, time.Seconds, time.Milliseconds);



            //Task[] task = new Task[n];
            //for (int i = 0; i < n; i++)
            //{
            //    task[i] = new Task(() => FileUpload(i));
            //    task[i].Start();
            //}            
            //await Task.WhenAll(task);

        }
        static void Main(string[] args)
        {
            FileUploadAsync(4);
            for (int i = 0; i < 5; i++)
            {

                Console.Write("*");
                Thread.Sleep(1000);
            }
            Console.Read();
        }
    }
}