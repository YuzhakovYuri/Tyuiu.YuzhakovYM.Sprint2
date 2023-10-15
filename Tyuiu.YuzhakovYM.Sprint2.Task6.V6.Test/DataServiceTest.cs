using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint2.Task6.V6.Lib;

namespace Tyuiu.YuzhakovYM.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 14;
            string res = ds.FindCardNameAndValue(m, k);
            string wait = "Туз пики";

            Assert.AreEqual(wait, res);
        }
    }
}
