using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint6.TaskReview.V18.Lib;

namespace Tyuiu.SysoevDA.Sprint6.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {

            DataService ds = new DataService();
            int[,] array = { { 5, 6, 5, 16, 8 },
                             { 9, 7,  5, 21, 5},
                             { 6, 5, 8, 19, 10 },
                             { 10, 5, 7, 22, 6 },
                             { 6, 7, 5, 18, 9 } };
            var res = ds.GetMatrix(array, 5, 10, 2, 0, 5);
            Assert.AreEqual(24, res);
        }
    }
}
