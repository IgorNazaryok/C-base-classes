using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Rectangle
    {
        double side1, side2;
        
        public Rectangle()
        {

        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return this.side1 * this.side2;
        }

        double PerimetrCalculator()
        {
            return 2*(this.side1 + this.side2);
        }
        public double Area
        {
           
            get
            {
                return AreaCalculator();
            }

        }
        public double Perimeter
        {

            get
            {
                return PerimetrCalculator();
            }

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the rectangle");
            Console.Write("Enter size side A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size side B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Rectangle rectangle = new Rectangle(a, b);

            Console.WriteLine("Area this rectangle = "+rectangle.Area);
            Console.WriteLine("Perimeter this rectangle = " + rectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
