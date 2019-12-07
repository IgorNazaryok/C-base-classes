using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Address
    {
        private string index, country, city, street, house, apartment;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }

        }
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }

        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }

        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }

        }
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }

        }
        public string Apartament
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address MyAddress = new Address();
            MyAddress.Index = "50047";
            MyAddress.Country = "Ukraine";
            MyAddress.City = "Pavlograd";
            MyAddress.Street = "Ivana Mazepi";
            MyAddress.House = "102";
            MyAddress.Apartament = "45";

            Console.WriteLine("My Address");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Index " + MyAddress.Index);
            Console.WriteLine("Country " + MyAddress.Country);
            Console.WriteLine("City " + MyAddress.City);
            Console.WriteLine("St. " + MyAddress.Street);
            Console.WriteLine("House " + MyAddress.House);
            Console.WriteLine("Apatament " + MyAddress.Apartament);
            Console.ReadLine();

        }
    }
}
