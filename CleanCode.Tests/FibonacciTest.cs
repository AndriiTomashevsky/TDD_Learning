using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestFibonacci()
        {
            int[] cases = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 };

            for (int i = 0; i < cases.Length; i++)
            {
                Assert.AreEqual(cases[i], Fib(i));
            }
        }

        private int Fib(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }
            return Fib(i - 2) + Fib(i - 1);
        }
    }
}
