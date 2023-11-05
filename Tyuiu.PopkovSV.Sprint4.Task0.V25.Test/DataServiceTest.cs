using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint4.Task0.V25.Lib;

namespace Tyuiu.PopkovSV.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}