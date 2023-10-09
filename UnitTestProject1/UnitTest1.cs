using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0, y = 0;

            x = Convert.ToInt32(Console.ReadLine());

            x++;

            y = x - 3;

            int a = 4;

            if ((x > 5) || (y < 0)) a = x;

            a += y;

            Console.WriteLine(a);


        }
    }
}
