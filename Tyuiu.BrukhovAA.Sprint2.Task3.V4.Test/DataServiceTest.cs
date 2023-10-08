using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint2.Task3.V4.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 11.000;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = Math.Round(0.0833333, 3);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = Math.Round(-0.50000, 3);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = Math.Round(-109.9000, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
