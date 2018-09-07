//Яковлев Николай.
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Recursy
    {
        class Program
        {                           
            static void Loop1(int a, int b)
            {
                if (a <= b)
                {
                    Console.Write(a + " ");
                    Loop1(++a, b);
                }
            }

            public static int Loop2(int a, int b)
            {
                if (a < b)
                {
                    return b + Loop2(a, b - 1);
                }             
                return b;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Метод выводящий все числа, от a до b. Метод подсчитывающий сумму этих чисел. a должно быть меньше b.");
                Console.WriteLine("Введите число a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b");
                int b = int.Parse(Console.ReadLine());

                Loop1(a, b);
                
                Console.WriteLine($"Сумма равна: {Loop2(a, b)}");
              
                
                Console.ReadKey();
            }
        }
    }
}
