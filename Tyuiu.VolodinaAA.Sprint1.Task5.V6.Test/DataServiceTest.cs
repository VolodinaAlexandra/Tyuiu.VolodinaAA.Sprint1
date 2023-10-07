using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            int k = 12;
            int n = ds.Calculate(k);
            int res = Convert.ToInt32(n);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
