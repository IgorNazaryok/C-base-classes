using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_3
{
    class Ship:Vehicle
    {
        int numberPassengers;
        string homePort;
        public Ship(int numberPassengers, string homePort)
            {
            this.numberPassengers = numberPassengers;
            this.homePort = homePort;
            this.x = new Random().Next(1, 100);
            this.y = new Random().Next(1, 100);
            }
        public void Info()
        {
            Console.WriteLine("Коодинаты: х - " + x + ", y - " + y + ";");
            Console.WriteLine("Порт приписки: " + homePort + "," + " количество мест: " + numberPassengers + ";");
            Console.WriteLine();
        }
    }
}
