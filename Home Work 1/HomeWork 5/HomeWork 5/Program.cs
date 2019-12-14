using System;

namespace HomeWork_5
{
    class Program
    {
        class Converter
        {
            double usa, eur, rub;
            public Converter(double usa, double eur, double rub)
            {
                this.usa = usa;
                this.eur = eur;
                this.rub = rub;
            }
            public double Usa
            {
                get
                {
                    return usa;
                }
            }
            public double Eur
            {
                get
                {
                    return eur;
                }
            }
            public double Rub
            {
                get
                {
                    return rub;
                }
            }
            public void UahToRub(double uah)
            {
                Console.WriteLine(uah + " uah = "+ (uah / this.rub) + " rub");
            }
            public void UahToUsa(double uah)
            {
                Console.WriteLine(uah + " uah = " + (uah / this.usa) + " usa");
            }
            public void UahToEur(double uah)
            {
                Console.WriteLine(uah + " uah = " + (uah / this.eur) + " eur");
            }
            public void RubToUah(double x)
            {
                Console.WriteLine(x + " rub = " + (x * this.rub) + " uah");
            }
            public void UsaToUah(double x)
            {
                Console.WriteLine(x + " usa = " + (x * this.usa) + " uah");
            }
            public void EurToUah(double x)
            { 
                Console.WriteLine(x + " eur = " + (x * this.eur) + " uah");
            }
        }
        static void Main(string[] args)
        {
            Converter converter = new Converter(24.4, 28.2, 0.41);
           
            string value = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Текущий курс валют: " + " 1 usa - " + converter.Usa + "грн.;" + " 1 eur - " + converter.Eur + "грн.;" + " 1 rub - " + converter.Rub + "грн.");
                Console.WriteLine("Какую операцию хотите выполнить: 1 - конвертировать гривны в др. валюту 2 - конвертировать др. валюту в гривны");
                value = Console.ReadLine();
            }
            while (value != "1" && value != "2");
           if(value=="1")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("В какую валюту хотите конвертировать гривны? 1-usa, 2-eur, 3-rub");
                    value = Console.ReadLine();
                }
                while (value != "1" && value != "2" && value != "3");
                Console.WriteLine("Введите конвертируемую сумму");
               double summa = Convert.ToDouble(Console.ReadLine());
                switch (value)
                {
                    case "1":
                        converter.UahToUsa(summa);
                        break;
                    case "2":
                        converter.UahToEur(summa);
                         break;
                    case "3":
                        converter.UahToRub(summa);
                        break;
                }
            }
            else
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Какую валюту хотите конвертировать в гривны? 1-usa, 2-eur, 3-rub");
                    value = Console.ReadLine();
                }
                while (value != "1" && value != "2" && value != "3");
                Console.WriteLine("Введите конвертируемую сумму");
                double summa = Convert.ToDouble(Console.ReadLine());
                switch (value)
                {
                    case "1":
                        converter.UsaToUah(summa);                 
                        break;
                    case "2":
                        converter.EurToUah(summa);                        
                        break;
                    case "3":
                        converter.RubToUah(summa);                        
                        break;
                }
            }
            
            
            
        }
    }
}
