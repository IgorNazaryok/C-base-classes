using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW_5
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)(ColorText.Cyan):
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(stroka);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case (int)(ColorText.DarkBlue):
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(stroka);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case (int)(ColorText.Green):
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(stroka);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case (int)(ColorText.Red):
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(stroka);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case (int)(ColorText.Yellow):
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(stroka);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                default: break;  
                    


            }
          
        }
    }
}
