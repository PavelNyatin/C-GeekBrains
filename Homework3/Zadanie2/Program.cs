using System;
using System.Collections.Generic;

/* а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
    */
namespace Zadanie2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<double> a = new List<double>();
            Console.WriteLine("Введите число");
            a = CheckAndConvert(Enum());
            foreach (var i in a) Console.Write("{0}  ", i);
            Console.WriteLine("  Сумма нечетных числел = {0}", Sum(a));
        }
        static public List<string> Enum()
        {
            List<string> a = new List<string>();
            string k = Console.ReadLine();
            while (k != "0")
            {
                a.Add(k);
                k = Console.ReadLine();
            }
            return a;
        }
        static public double Sum(List<double> a)
        {
            double sum = 0;
            foreach (double i in a)
            {

                if (i % 2 != 0 && i > 0) sum += i;
            }
            return sum;
        }
        static public List<double> CheckAndConvert(List<string> a)
        {
            bool check = true;
            List<double> vihod = new List<double>();
            foreach (string c in a)
            {
                check = double.TryParse(c, out double j);
                if (check == false) Console.WriteLine("Недопустимое значение - {0}", c);
                else vihod.Add(Convert.ToDouble(c));
            }
            return vihod;
        }

    }
}
           

