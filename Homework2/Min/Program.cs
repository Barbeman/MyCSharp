//Яковлев Николай.
//Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Min
    {
        class Program
        {
            static double Min(double n1, double n2, double n3)
            {
                if ((n1 < n2 || n1 == n2) && n1 < n3) return n1;
                else if ((n2 < n1 || n2 == n1) && n2 < n3) return n2;
                else return n3;

            }

            static void Main(string[] args)
            {
                Console.WriteLine("Вычислим минимальное из трех чисел.");
                Console.WriteLine("Введите первое число.");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число.");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число.");
                double num3 = double.Parse(Console.ReadLine());
                if (num1 == num2 && num2 == num3)
                    Console.WriteLine("Введенные числа равны");
                else
                    Console.WriteLine($"Минимальное число = {Min(num1, num2, num3)}");
                Console.ReadKey();
            }
        }
    }
}
