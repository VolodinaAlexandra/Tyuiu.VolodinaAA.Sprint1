using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DeleteMiddleLetterValid()
        {
            DataService ds = new DataService();
            string value = "алеша пошёл на рыбалку и поймал рыбку";
            var wait = "алша поёл на рыблку и поймал рыку";
            var res = ds.DeleteMiddleLetter(value);
            Assert.AreEqual(wait, res);
        }
    }
}
