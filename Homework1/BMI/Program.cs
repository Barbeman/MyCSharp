//Яковлев Николай.
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace BMI
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Давайте расчитаем ваш Индекс Массы Тела.");
                Console.WriteLine("Введите ваш вес в кг.");
                float weight = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите ваш рост в метрах.");
                float height = Convert.ToSingle(Console.ReadLine());
                float bmi = weight / (height * height);
                Console.WriteLine($"Ваш Индекс Массы тела равняется: {bmi:F2}");

                Console.ReadKey();
            }
        }
    }
}