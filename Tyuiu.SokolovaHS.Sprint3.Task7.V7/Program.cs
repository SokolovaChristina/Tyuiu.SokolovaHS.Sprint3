using System;
using Tyuiu.SokolovaHS.Sprint3.Task7.V7.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - 3x на диапазоне [-5; 5] с шагом 1       *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.    *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     | {1,8:f2}  |", x, result[i]);
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadLine();
        }
    }
}