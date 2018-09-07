//Яковлев Николай.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Distance
    {
        class Program
        {
            static double Distance(double coordX1, double coordX2, double coordY1, double coordY2)
            {
                return Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2));
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Расчитаем расстояние между двумя точками на плоскости, зная их координаты.");
                Console.WriteLine("Введите координату первой точки по оси X");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату первой точки по оси Y");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату второй точки по оси X");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату второй точки по оси Y");
                double y2 = Convert.ToDouble(Console.ReadLine());

                //double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine($"Расстояние между точками равно: {Distance(x1, x2, y1, y2):F2}");

                Console.ReadKey();

            }
        }
    }
}