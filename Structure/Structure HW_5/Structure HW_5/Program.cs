using System;

namespace Structure_HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст сообщения: ");
            string stroka = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Выберите один из доступных цветов вывода сообщения: ");
            for (ColorText colorText = ColorText.Red; colorText <= ColorText.DarkBlue; colorText++)
            Console.WriteLine($"{ colorText}: { (int)colorText}" +"\t");
            int color =Convert.ToInt32 (Console.ReadLine());
            Printer.Print(stroka, color);
        }
        
    }

}
