using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task4.V13.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);
            double wait = -0.023;  // Ожидаемое значение

            Assert.AreEqual(wait, result);
        }
    }
}