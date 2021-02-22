using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CountFigureSquare;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(2, 4, 3);
                triangle.B = 3;
                triangle.Name = "FirstTriangle";
                var b = triangle.CountSquare();
                Console.WriteLine($"Square = {b}");
                Console.WriteLine($"It is right triangle {triangle.rightTriangle}");
                Console.WriteLine($"Name {triangle.Name}");
                Сircle сircle = new Сircle(5);
                Console.WriteLine("_______________");
                var k = сircle.CountSquare();
                сircle.Name = "FirstSircle";
                Console.WriteLine($"Name {сircle.Name}");
                Console.WriteLine($"Square = {k}");
                Console.WriteLine("_______________");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            Console.ReadLine();

        }
    }
}
