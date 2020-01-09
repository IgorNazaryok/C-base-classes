using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW_1
{
    struct Notebook
    {
        string model, manufacturer;
        int price;
        public Notebook (string model, string manufacturer, int price)
            {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            }
        public void Print ()
        {
            Console.WriteLine("Модель: {0} Производитель: {1} Цена: {2} ", this.model,this.manufacturer,this.price);
        }
    }
}
