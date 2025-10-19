using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SokolovaHS.Sprint3.Task5.V1.Lib
{
    public class DataService : ISprint3Task5V1
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double denominator = Math.Cos(k) + x;
                    sum += 1 / denominator;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}