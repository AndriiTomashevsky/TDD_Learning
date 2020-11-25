using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void TestSequentialSearch()
        {
            int[] list = new[] { 0, 1, 2, 3, 4, 5 };
            int N = list.Length;

            Assert.AreEqual(1, Algorithm.SequentialSearch(list, 0, N));
            Assert.AreEqual(6, Algorithm.SequentialSearch(list, 5, N));
            Assert.AreEqual(0, Algorithm.SequentialSearch(list, 6, N));
        }

        [TestMethod]
        public void TestBinarySearch()
        {
            int[] list = new[] { 0, 1, 2, 3, 4, 5 };
            int N = list.Length;

            Assert.AreEqual(0, Algorithm.BinarySearch(list, 0, N));
            Assert.AreEqual(5, Algorithm.BinarySearch(list, 5, N));
            Assert.AreEqual(-1, Algorithm.BinarySearch(list, 6, N));
        }
    }
}
