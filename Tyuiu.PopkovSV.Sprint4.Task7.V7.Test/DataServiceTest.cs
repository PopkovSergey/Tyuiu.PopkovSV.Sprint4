using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint4.Task7.V7.Lib;

namespace Tyuiu.PopkovSV.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc() 
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string str = "31415926";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}