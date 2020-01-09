using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW_2
{
    struct Train
    {
       string destination, departureTime;
        int trainNuber;
        public Train (string destination, int trainNuber, string departureTime)
        {
            this.departureTime = departureTime;
            this.destination = destination;
            this.trainNuber = trainNuber;
        }
        public int TrainNuber
        {
            get { return trainNuber; }
        }
        public void ShowInfo()
        {
           Console.WriteLine($"Номер поезда: {this.trainNuber} \t Пункт назаначения: {destination} \t Время отправления: {departureTime}");
        }
    }
}
