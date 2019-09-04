// Написать метод, возвращающий минимальное из трёх чисел
// Нятин Павел
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наименьшее число =" + Calculate(a, b, c).ToString());
        }
        static public int Calculate(int a, int b, int c)
        {
            int result = a;
            for (int i = 0; i < 3; i++)
            {
                if (result < b && result < c) return result;
                else result = b;
                if (result < c) return result;
                else result = c;
            }
            return result;
        }
    }
}
