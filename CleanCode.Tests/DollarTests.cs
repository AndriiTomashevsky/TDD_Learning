using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class DollarTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [TestMethod]
        public void TestSimpleAddition()
        {
            IExpression sum = Money.Dollar(5).Plus(Money.Dollar(5));
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");

            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [TestMethod]
        public void TestPlusReturnSum()
        {
            IExpression expression = Money.Dollar(5).Plus(Money.Dollar(5));
            Sum sum = (Sum)expression;

            Assert.AreEqual(Money.Dollar(5), sum.augent);
            Assert.AreEqual(Money.Dollar(5), sum.addend);
        }

        [TestMethod]
        public void TestReduceSum()
        {
            IExpression expression = Money.Dollar(3).Plus(Money.Dollar(4));
            Bank bank = new Bank();

            Money result = bank.Reduce(expression, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [TestMethod]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();

            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

    }
}
