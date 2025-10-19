using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SokolovaHS.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int k = startValue;

            do
            {
                double term = Math.Pow((double)value / k, 3);
                product *= term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}