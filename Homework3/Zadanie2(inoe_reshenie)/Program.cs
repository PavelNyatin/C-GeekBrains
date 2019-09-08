/* а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
При возникновении ошибки вывести сообщение.Напишите соответствующую функцию
Нятин Павел
*/
using System;
using System.Collections.Generic;

namespace Zadanie2_inoe_reshenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = AllValues();
            foreach (double a in myList)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
            Console.WriteLine("Сумма всех нечетных положительных чисел = {0}", Sum(myList));

        }

        static List<double> AllValues()
        {
            double a = 0;
            string b = Console.ReadLine();
            List<double> vihod = new List<double>();
            while (b != "0")
            {
                a = MyConvert(b);
                if (a != 0) vihod.Add(a);
                b = Console.ReadLine();
            }
            return vihod;
        }

        static double MyConvert(string a)
        {
            if (double.TryParse(a, out double j) == true) return Convert.ToDouble(a);
            else
            {
                Console.WriteLine("Недопустимое значение: {0}", a);
                return 0;
            }
        }

        static double Sum(List<double> a)
        {
            double sum = 0;
            foreach (double k in a)
            {
                if (k % 2 != 0 && k>0) sum += k;
            }
            return sum;
        }
    }
}
