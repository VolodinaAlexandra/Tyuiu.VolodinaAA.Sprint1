using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task7.V8.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 20;
            double z = 96.633;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
