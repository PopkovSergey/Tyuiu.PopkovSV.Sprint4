using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint4.Task1.V2.Lib;

namespace Tyuiu.PopkovSV.Sprint4.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[] arr = new int[] { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(arr), 34);
        }
    }
}