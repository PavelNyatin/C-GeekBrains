// Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, используя структуру DateTime
//Нятин Павел
using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(Amount());
            DateTime end = DateTime.Now;
            Console.WriteLine("Затраченое время  " + (end-start));
        }
        static public int Amount()
        {
            int count = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                int sum = 0;
                foreach (var x in i.ToString())
                {
                    int a = Convert.ToInt32(x.ToString());
                    sum += a;
                }
                if (i % sum == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
