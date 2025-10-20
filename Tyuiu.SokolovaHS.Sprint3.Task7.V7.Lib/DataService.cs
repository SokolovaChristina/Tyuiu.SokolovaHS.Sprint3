using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SokolovaHS.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 2;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.001) // x = -2
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double fx = Math.Cos(x) + (Math.Cos(x) / denominator) - 3 * x;
                    valueArray[count] = Math.Round(fx, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}