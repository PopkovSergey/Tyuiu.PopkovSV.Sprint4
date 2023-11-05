using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint4.Task2.V11.Lib;

namespace Tyuiu.PopkovSV.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5, 8, 1, 4, 4, 1 };
            int res = ds.Calculate(numsArray);

            Assert.AreEqual(34, res);
        }
    }
}