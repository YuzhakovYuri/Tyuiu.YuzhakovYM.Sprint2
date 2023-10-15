using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint2.Task4.V2.Lib;

namespace Tyuiu.YuzhakovYM.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 3;
            var res = ds.Calculate(x, y);
            double wait = 1.6;

            Assert.AreEqual(wait, res);
        }
    }
}
