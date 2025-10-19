using System;
using Tyuiu.SokolovaHS.Sprint3.Task2.V14.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле p = ∏(x/k)^3 для k=1..6 при x = 5         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine($"Значение X = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadLine();
        }
    }
}