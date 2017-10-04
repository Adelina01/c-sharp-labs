using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                      Created by Alina Kazmirchuk , group IS-51\n");
            Console.WriteLine("                                    Pattern - Builder \n");
            Console.WriteLine("                                    Creating Shape \n\n\n");
            //создаем объект менеджера
            Manager manager = new Manager();
            //создаем строителя для круга
            ShapeBuilder builder = new CircleBuilder();
            //строим фигуру
            Console.WriteLine("----------Creating a new circle----------");
            Shape circle = manager.Draw(builder);
            Console.WriteLine(circle.ToString());

            //создаем строителя для треугольника
            builder = new TriangleBuilder();
            //строим фигуру
            Console.WriteLine("----------Creating a new triangle----------");
            Shape triangle = manager.Draw(builder);
            Console.WriteLine(triangle.ToString());

            //создаем строителя для прямоугольника
            builder = new RectangleBuilder();
            //строим фигуру
            Console.WriteLine("----------Creating a new rectangle-----------");
            Shape rectangle = manager.Draw(builder);
            Console.WriteLine(rectangle.ToString());
            Console.ReadKey();

        }
    }
}
