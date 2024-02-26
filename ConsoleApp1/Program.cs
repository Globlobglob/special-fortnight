using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

       

        enum Figure
        {
            Triangle,
            Circle,
            Square
        }


        static void Main(string[] args)
        {
            

            
            Console.WriteLine("Enter name of figure ");
            
            
            bool flag = true;
            while (flag)
            {
                switch ()
                {
                    case Figure.Circle:
                        Console.WriteLine("Its Circle");
                        break;
                }
            }
            Console.ReadKey();
        }
       
    }
}
