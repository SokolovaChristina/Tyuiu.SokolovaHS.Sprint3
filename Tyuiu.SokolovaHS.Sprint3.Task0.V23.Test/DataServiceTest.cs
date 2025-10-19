using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaHS.Sprint3.Task0.V23.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.297; 

            Assert.AreEqual(wait, result);
        }
    }
}
