using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task6.V13.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();

            int startValue = 8;
            int stopValue = 17;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 117;  

            Assert.AreEqual(wait, result);
        }
    }
}