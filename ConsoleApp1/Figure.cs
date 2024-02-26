using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Figure
    {
        string name;
        public string Name { get; set; }

        public Figure() { }
        public Figure(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
        virtual public void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
