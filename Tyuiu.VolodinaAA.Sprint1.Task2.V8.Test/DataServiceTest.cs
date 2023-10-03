using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            int a = 3;
            int b = 5;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(16, res);
        }
    }
}
