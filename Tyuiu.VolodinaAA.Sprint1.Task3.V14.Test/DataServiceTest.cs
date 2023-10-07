using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReverseNumberValid()
        {
            DataService ds = new DataService();
            double number = 236;
            double wait = 632;
            var res = ds.ReverseNumber(number);
            Assert.AreEqual(wait, res);
        }
    }
}
