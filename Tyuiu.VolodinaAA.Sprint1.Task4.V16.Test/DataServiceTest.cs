using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task4.V16.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 9;
            double wait = 0.077;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}
