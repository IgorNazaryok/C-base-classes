using System;
using System.Collections.Generic;
using System.Text;

namespace Geniric_5
{
    public class Car
    {
        string brand;       
        string year;

        public Car() { }
        public Car(string brand, string year)
        {
            this.brand = brand;
            this.year = year;
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }
        public void print()
        {
            Console.Write(brand + "  "  + year);
            Console.WriteLine();
        }
    }

}
