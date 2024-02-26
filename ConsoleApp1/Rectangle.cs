using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle:Figure
    {
        int side1;
        int side2;

        public int Side2 { get => side2; set => side2 = value; }
        public int Side1 { get => side1; set => side1 = value; }

        public Rectangle() 
        { 
        
        }
        public Rectangle(int side1,int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return Side1 * Side2;
        }

        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Area:{Area()}\nPerimeter{Perimeter()}");
        }

    }
}
