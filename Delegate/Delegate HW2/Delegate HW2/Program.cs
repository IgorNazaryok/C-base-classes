using System;

namespace Delegate_HW2
{
    public delegate double Arithmetic(int a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic Add = null;
            Arithmetic Sub = null;
            Arithmetic Mul = null;
            Arithmetic Div = null;
            Add = (a, b) => { return a + b; };
            Sub = (a, b) => { return a - b; };
            Mul = (a, b) => { return a * b; };
            Div = (a, b) => { return b != 0 ? a / b : b; };
            string operation = "";
            int a, b;

            do
            {
                Console.WriteLine("Выберите тип операцию + - * / или введите 'e' (exit) для выхода");                
                operation = Console.ReadLine();
                if (operation == "e") break;
                Console.WriteLine("Выберите первый операнд:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите второй операнд:");
                b = int.Parse(Console.ReadLine());

                switch (operation) 
                { 
                    case "+": 
                        { 
                            Console.WriteLine("{0} + {1} = {2}", a, b, Add(a, b)); 
                            break;
                        } 
                    case "-": 
                        { 
                            Console.WriteLine("{0} - {1} = {2}", a, b, Sub(a, b));
                            break;
                        } 
                    case "*": 
                        {
                            Console.WriteLine("{0} * {1} = {2}", a, b, Mul(a, b));
                            break;
                        } 
                    case "/":
                        { 
                            if (Div(a, b) != b) Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));
                            else Console.WriteLine("Деление на ноль");
                            break;
                        }
                    default: 
                        {
                          break;
                        }
                }
            }
            while (operation != "e");            
        }
    }
}