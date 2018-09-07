//Яковлев Николай.
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных
//положительных чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Sum
    {
        class Program
        {
            static void Main(string[] args)
            {
                int num = 0;
                int num2 = 0;
                Console.WriteLine("Подсчитаем сумму всех нечетных, положительных чисел, введенных вами. Ввод нуля выводит сумму.");
                do
                {
                    Console.WriteLine("Введите число.");
                    num = int.Parse(Console.ReadLine());
                    if (num > 0 && (num % 2) != 0)
                        num2 += num;
                } while (num != 0);

                Console.WriteLine($"Сумма равна: {num2}");
                Console.ReadKey();
            }
        }
    }
}
