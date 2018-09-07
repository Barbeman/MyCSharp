//Яковлев Николай
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить
//работу класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakovlevHelpLib;

namespace Yakovlev
{
    namespace Complex
    {        
        class Complex
        {              
            double im;            
            double re;
            
            public Complex()
            {
                im = 0;
                re = 0;
            }
           
            public Complex(double im, double re)
            {               
                this.im = im;
                this.re = re;
            }

            public Complex Plus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = x2.im + im;
                x3.re = x2.re + re;
                return x3;
            }

            public Complex Minus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = im - x2.im;
                x3.re = re - x2.re;
                return x3;
            }

            public Complex Multipl(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = (x2.im*im)- (x2.re * re);
                x3.re = (re * x2.im) + (im * x2.re);
                return x3;
            }
            
            public double Im
            {
                get { return im; }
                set { im = value; }
            }

            public double Re
            {
                get { return re; }
                set { re = value; }
            }
                        
            public string ToString()
            {
                if (re > 0)
                    return im + "+" + re + "i";
                else if (re == 0)
                    return im + " " + re + "i";
                else
                    return im +""+ re + "i";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Complex A, B, C, D, E;
                Console.WriteLine("Комплексные числа.");
                Console.WriteLine("Введите вещественные числа для числа А.");
                A = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine("Введите вещественные числа для числа B.");
                B = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                

                C = A.Plus(B);
                D = A.Minus(B);
                E = A.Multipl(B);
                
                
                Console.WriteLine($"Число А: {A.ToString()}; Число B: {B.ToString()}; Сумма чисел: {C.ToString()}, разность чисел: {D.ToString()}, произведение чисел {E.ToString()}");
                Console.ReadKey();
                

                
            }
        }
    }
}