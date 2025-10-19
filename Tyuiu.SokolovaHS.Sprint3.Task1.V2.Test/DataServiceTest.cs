using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task1.V2.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double result = ds.GetSumSeries(startValue, stopValue);
            double wait = 0.968;

            Assert.AreEqual(wait, result);
        }
    }
}