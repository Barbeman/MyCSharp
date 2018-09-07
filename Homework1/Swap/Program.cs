//Яковлев Николай
//Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Swap
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("поменяем местами 2 переменные.");
                Console.WriteLine("введите переменную а.");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("введите переменную b.");
                float b = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"a = {a}; b = {b}");

                //float temporary = a;
                //a = b;
                //b = temporary;

                a = a + b;
                b = b - a;
                b = -b;
                a = a - b;

                Console.WriteLine("меняем местами");
                Console.WriteLine($"a = {a}; b = {b}");

                Console.ReadKey();
            }
        }
    }
}
