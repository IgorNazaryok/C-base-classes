using System;

namespace _2_Home_work_1
{
    class Printer
    {
       public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class InkjetPrinter : Printer
    {
        public new void Print(string value)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        } 
    }
    class LaserPrinter : Printer
    {
        public new void Print(string value)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Текст распечатан на принтере");
            InkjetPrinter iprinter = new InkjetPrinter();
            iprinter.Print("Текст распечатан на струйном принтере");
            LaserPrinter lprinter = new LaserPrinter();
            lprinter.Print("Текст распечатан на лазерном принтере");
            Console.WriteLine(new string('-', 30));

            Printer iprinterUP = iprinter as Printer;
            iprinterUP.Print("Текст распечатан на струйном принтере");
            Printer lprinterUP = lprinter as Printer;
            lprinterUP.Print("Текст распечатан на лазерном принтере");
            Console.WriteLine(new string('-', 30));

            InkjetPrinter iprinterDown = iprinterUP as InkjetPrinter;
            iprinterDown.Print("Текст распечатан на струйном принтере");
            LaserPrinter lprinterDown = lprinterUP as LaserPrinter;
            lprinterDown.Print("Текст распечатан на лазерном принтере");
        }
    }
}
