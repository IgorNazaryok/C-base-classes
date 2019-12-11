using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_3
{
    class Plane: Vehicle
    {
        double altitude;
        int numberPassengers;
        public Plane (double altitude,int numberPassengers)
        {
            this.altitude = altitude;
            this.numberPassengers = numberPassengers;
            this.x = new Random().Next(1, 100);
            this.y = new Random().Next(1, 100);
        }
        public void Info()
        {
            Console.WriteLine("Коодинаты: х - " + x + ", y - " + y + ";");
            Console.WriteLine("Высота полета: " + altitude + " метров," + " количество мест: " + numberPassengers+";");
            Console.WriteLine();
        }
    }
}
