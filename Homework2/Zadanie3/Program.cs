//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Нятин Павел
using System;
using System.Collections.Generic;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            Console.WriteLine("Сумма нечетных чисел равна = " + Sum());
        }
        static public double Sum()
        {
            double sum = 0;
            double b = Convert.ToDouble(Console.ReadLine());
            List<double> a = new List<double>();
            while (b != 0)
            {
                a.Add(b);
                b = Convert.ToDouble(Console.ReadLine());
            }
            foreach (double c in a)
            {
                if (c > 0 && c % 2 != 0) sum = sum + c;
            }
            return sum;
        }
    }
}
