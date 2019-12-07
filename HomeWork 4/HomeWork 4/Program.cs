using System;

namespace HomeWork_4
{
    class Program
    {
        class Point
        {
            int x, y;
            string pName;
            public int X
            {
             get
                {
                    return x;
                }
            }
            public int Y
            {
                get
                {
                    return y;
                }
            }
            public string PName
            {
                get
                {
                    return pName;
                }
            }
           public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.pName = name;
            }
        }
        class Figure
        {
            Point a,b,c,d,e;
            int type = 0;
            public Figure(Point a, Point b, Point c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                type = 1;

              Console.Write("Rectangle name: "+this.a.PName+this.b.PName+this.c.PName); 
            }
            public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
            {
               this.d = d;
                Console.Write(this.d.PName);
                type = 2;
            }
            public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
            {
                this.e = e;
                Console.Write(this.e.PName);
                type = 3;
            }
            public double LengthSide(Point a, Point b)
            {
               return Math.Sqrt(Math.Pow((b.X-a.X),2)+ Math.Pow((b.Y - a.Y), 2));
            }
            public void PerimetrCalculator()
            {
               switch(type)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Perimetr rectangle: "+ (LengthSide(a, b)+ LengthSide(b, c)+ LengthSide(c, a)));
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Perimetr rectangle: ", LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a));
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Perimetr rectangle: ", LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a));
                        break;
                }
                   
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");
            
            Figure rectangle = new Figure(A, B, C);
            rectangle.PerimetrCalculator();
            
        }
    }
}
