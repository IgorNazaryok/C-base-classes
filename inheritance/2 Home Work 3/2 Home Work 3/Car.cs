using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_3
{
    class Car:Vehicle
    {
        public Car(double price, double speed, string yearIssue):base(price, speed, yearIssue)
        {
            this.x = new Random().Next(1, 100);
            this.y = new Random().Next(1, 100);
        }
        public void Info()
        {
            Console.WriteLine("Коодинаты: х - " + x + ", y - " + y+";");
            Console.WriteLine("Цена: " + price +"$,"+ " скорость: " + speed +"км.ч,"+ " год выпуска: " + yearIssue + ";");
            Console.WriteLine();
        }
    }
}
