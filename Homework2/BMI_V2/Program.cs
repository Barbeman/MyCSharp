//Яковлев Николай.
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
//массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace BMI_V2
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Давайте расчитаем ваш Индекс Массы Тела.");
                Console.WriteLine("Введите ваш вес в кг.");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ваш рост в метрах.");
                double height = Convert.ToDouble(Console.ReadLine());
                double bmi = weight / Math.Pow(height, 2);
                Console.WriteLine($"Ваш Индекс Массы тела равняется: {bmi:F2}");
                if(bmi <= 24.99 && bmi >= 18.5)                
                    Console.WriteLine("Поздравляю ваш вес в норме.");
                else if (bmi < 18.5)                
                    Console.WriteLine($"Вам надо набрать {((18.5-bmi)* Math.Pow(height, 2)):F2} кг.");
                else
                    Console.WriteLine($"Вам надо сбросить {((bmi - 24.99) * Math.Pow(height, 2)):F2} кг.");


                Console.ReadKey();
            }
        }
    }
}
