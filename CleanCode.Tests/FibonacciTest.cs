using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    //[TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestFibonacci()
        {
            int[,] cases = { { 0, 0 }, { 1, 1 }, { 2, 1 }, { 3, 2 } };

            for (int i = 0; i < cases.Length / 2; i++)
            {
                Assert.AreEqual(cases[i, 1], Fib(cases[i, 0]));
            }
        }

        private int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
