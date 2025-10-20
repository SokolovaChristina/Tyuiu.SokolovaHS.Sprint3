using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task7.V7.Lib;
using System;

namespace Tyuiu.SokolovaHS.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                16.76, 13.51, 10.26, 6.7, 3.46, 0, -2.98, -6.04, -8.83, -11.84, -14.84
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}