using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    //[TestClass]
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

        [TestMethod]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [TestMethod]
        public void TestIdentityRate()
        {
            Bank bank = new Bank();
            Assert.AreEqual(1, bank.Rate("USD", "USD"));
        }

        [TestMethod]
        public void TestMixedAddition()
        {
            IExpression fiveDollars = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);

            Money result = bank.Reduce(fiveDollars.Plus(tenFrancs), "USD");

            Assert.AreEqual(Money.Dollar(10), result);
        }

        [TestMethod]
        public void TestSumPlusMoney()
        {
            IExpression fiveDollars = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            IExpression sum = new Sum(fiveDollars, tenFrancs).Plus(fiveDollars);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);

            Money result = bank.Reduce(sum, "USD");

            Assert.AreEqual(Money.Dollar(15), result);
        }

        [TestMethod]
        public void TestSumTimes()
        {
            IExpression fiveDollars = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            IExpression sum = new Sum(fiveDollars, tenFrancs).Times(2);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);

            Money result = bank.Reduce(sum, "USD");

            Assert.AreEqual(Money.Dollar(20), result);
        }
    }
}
