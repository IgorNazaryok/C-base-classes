using System;

namespace Home_Work_8
{
  
    class Invoice
    {
        readonly int account; //номер счета
        readonly string customer, provider; //покупатель поставщик
        string article; //товар
        int quantity; //количество новара
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double Cost(string article, int quantity) //товар и количество
        {
            this.article = article; //товар
            this.quantity = quantity; //количество новара        
            double price =new Random().Next(1000, 4500)/100;
            return this.quantity * price;
        }
        public string Article
        {
            get
            {
                return article;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
        }
    }
    
    class Program
    {              
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(30245784, "LTD Ko&Ko", "LTD Ro&Ko");
            invoice.Cost("Book", 5);
            Console.WriteLine("Стоимость "+ invoice.Quantity + " единиц товара " + invoice.Article + " составляет " + invoice.Cost("Book", 5)+" грн.");
        }
    }
}
