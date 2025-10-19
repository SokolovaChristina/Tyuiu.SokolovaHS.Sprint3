using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint3.Task3.V27.Lib;

namespace Tyuiu.SokolovaHS.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "lbt, g567kid f!";
            int result = ds.ConvertStringToInt(str);
            int wait = 567;  

            Assert.AreEqual(wait, result);
        }
    }
}