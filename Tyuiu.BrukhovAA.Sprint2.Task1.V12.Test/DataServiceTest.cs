using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint2.Task1.V12.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
