using System;

namespace _2_Home_Work_3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Plane AirbusA320 = new Plane(1324, 180);
            Car AMG = new Car(120000, 245, "2015");
            Ship Rio = new Ship(1200, "Геленджик");
            AMG.Info();
            AirbusA320.Info();
            Rio.Info();
        }
    }
}
