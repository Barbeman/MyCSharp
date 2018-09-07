//Николай Яковлев
//Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
//программу, демонстрирующую все разработанные элементы класса.
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
//ArgumentException("Знаменатель не может быть равен 0");
//** Добавить упрощение дробей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Fraction
    {
        class Fraction
        {
            int num;
            int den;

            public Fraction()
            {
                num = 1;
                den = 1;
            }

            public Fraction(int num, int den)
            {
                this.num = num;
                if (den == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else this.den = den;
            }

            public int Num
            {
                get { return num; }
                set { num = value; }
            }

            public int Den
            {
                get { return den; }
                set { den = value; }
            }


            public Fraction Plus(Fraction a)
            {
                Fraction b = new Fraction();
                b.num = (num * a.den) + (a.num * den);
                b.den = den * a.den;
                int nod = NOD(b.num, b.den);
                b.num /= nod;
                b.den /= nod;
                return b;
            }

            public Fraction Minus(Fraction a)
            {
                Fraction b = new Fraction();
                b.num = (num * a.den) - (a.num * den);
                b.den = den * a.den;
                int nod = NOD(b.num, b.den);
                b.num /= nod;
                b.den /= nod;
                return b;
            }

            public Fraction Multipl(Fraction a)
            {
                Fraction b = new Fraction();
                b.num = num * a.num;
                b.den = den * a.den;
                int nod = NOD(b.num, b.den);
                b.num /= nod;
                b.den /= nod;
                return b;
            }

            public Fraction Div(Fraction a)
            {
                Fraction b = new Fraction();
                b.num = num * a.den;
                b.den = den * a.num;
                int nod = NOD(b.num, b.den);
                b.num /= nod;
                b.den /= nod;
                return b;
            }

            public string ToStr()
            {
                return num + "/" + den;
            }

            static int NOD(int a, int b)
            {
                if (b == 0)
                    return Math.Abs(a);
                return NOD(b, a % b);
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Fraction A, B, C, D, E, F;
                Console.WriteLine("Дроби.");
                Console.WriteLine("Введите числитель и знаминатель для дроби А.");
                A = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите числитель и знаминатель для дроби B.");
                B = new Fraction(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                C = A.Plus(B);
                D = A.Minus(B);
                E = A.Multipl(B);
                F = A.Div(B);

                Console.WriteLine($"Дробь A: {A.ToStr()}, дробь B: {B.ToStr()}, сумма = {C.ToStr()}, разность = {D.ToStr()}, произведение = {E.ToStr()}, частное = {F.ToStr()} ");
                Console.ReadKey();

            }
        }
       
    }
}
