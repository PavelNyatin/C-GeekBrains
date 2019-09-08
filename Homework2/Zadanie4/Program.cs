//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.
//Нятин Павел
using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string pass = Console.ReadLine();
                if (Check(log, pass) == true)
                {
                   Console.WriteLine("Логин и пароль приняты!");
                   break;
                }
                else Console.WriteLine("Вы ввели не верный логин или пароль. У вас осталось "+ (2-count) + " попытки!");
                count++;
            }
            while (count < 3);
        }
        static public bool Check(string log,string pass)
        {
            bool result = false;
            if (log == "root" && pass == "GeekBrains") result = true;
            return result;
        }

    }
}
