using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task2.V14.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 10220.275;  // Ожидаемое значение

            Assert.AreEqual(wait, result);
        }
    }
}