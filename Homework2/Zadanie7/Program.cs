//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
//Нятин Павел
using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) Console.WriteLine("Первое число должно быть меньше второго!!");
            else
            {
                Chisla(a, b);
                Console.WriteLine();
                Sum(a, b, 0);
            }
        }
        static public int Chisla(int a, int b)
        {
            Console.Write(b + "  ");
            if (a == b) return 0;
            else
            {
                Chisla(a, b-1);               
            }           
            return 0;
        }

        static public void Sum(int a, int b, int sum)
        {
            sum += b;
            if (a == b) Console.WriteLine(sum);
            else
            {               
                Sum(a, b - 1, sum);                
            }
        }
    }
}
