/*
 * 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.
Нятин Павел
 * */
using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую дробь");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0}/{1}",a,b);
            Console.WriteLine("Введите вторую дробь");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0}/{1}", c, d);
            Fraction test = new Fraction(a, b, c, d);
            ArgumentException e = new ArgumentException("Деление на 0!");
            if (b == 0 || d == 0) Console.WriteLine(e.Message);
            else
            {
                test.Sum();
                test.Div();
                test.Mult();
                test.Diff();
                test.Simplification(a, b, "Упрощение 1й дроби");
                test.Simplification(c,d,"Упрощение 2й дроби");
            }
        }
    }


    class Fraction
    {

        public int a;
        public int b;
        public int c;
        public int d;
        public Fraction(int x, int y, int z, int t) { a = x; b = y; c = z; d = t; }
        public void Sum()
        {
            Console.WriteLine("{0}/{1}+{2}/{3}=" + (a * d + c * b) +"/" + (b*d), a, b, c, d);
        }
         public void Div()
         {

            Console.WriteLine("{0}/{1}:{2}/{3}=" + (a * d) + "/" + (b * c), a, b, c, d);

         }
         public void Diff()
         {
            Console.WriteLine("{0}/{1}-{2}/{3}=" + (a * d - c * b) + "/" + (b * d), a, b, c, d);
         }
         public void Mult()
         {
            Console.WriteLine("{0}/{1}*{2}/{3}=" + (a * c) + "/" + (b * d), a, b, c, d);
         }
        public void Simplification(int a,int b,string e)
        {
            int x1 = a;
            int x2 = b;
            int i = 2;
            while ( i<100000)
            {
                if (x1 % i == 0 && x2 % i == 0)
                {
                    x1 = x1 / i;
                    x2 = x2 / i;
                }
                else i++;
            }
            Console.WriteLine("Упрощение {2}/{3}={0}/{1}",x1,x2,a,b);
        }

    }
}
