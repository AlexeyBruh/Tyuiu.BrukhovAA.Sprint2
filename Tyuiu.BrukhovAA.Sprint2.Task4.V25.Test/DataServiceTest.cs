using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint2.Task4.V25.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidExpression1()
        {
            double x = 10;
            double y = 20;
            double z = Math.Round(ds.Calculate(x, y), 3);
            double wait = Math.Round(1.48595, 3);
            Assert.AreEqual(wait, z);

        }
        [TestMethod]
        public void ValidExpression2()
        {
            double x = 1;
            double y = -200;
            double z = Math.Round(ds.Calculate(x, y), 3);
            double wait = Math.Round(-200.01, 3);
            Assert.AreEqual(wait, z);
        }
    }
}
