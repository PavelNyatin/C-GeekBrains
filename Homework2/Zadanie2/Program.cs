//Написать метод подсчета количества цифр числа.
//Нятин Павел
using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество цифр введенного числа = " + Value(a).ToString());
        }
        static public int Value(int a)
        {
            string b = a.ToString();
            int i = 0;
            foreach (char x in b) i++;
            return i;
        }
    }
}
