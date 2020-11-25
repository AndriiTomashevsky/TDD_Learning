using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class ArraysAndStringsTest
    {
        [TestMethod]
        public void TestIsUnique()
        {
            Assert.AreEqual(true, Algorithm.IsUnique("a"));
            Assert.AreEqual(false, Algorithm.IsUnique("aa"));
            Assert.AreEqual(true, Algorithm.IsUnique("ab"));
            Assert.AreEqual(false, Algorithm.IsUnique("aca"));
            Assert.AreEqual(false, Algorithm.IsUnique("acad"));
            Assert.AreEqual(false, Algorithm.IsUnique("accd"));
            Assert.AreEqual(false, Algorithm.IsUnique("acdd"));
            Assert.AreEqual(false, Algorithm.IsUnique("abcdefgch"));
        }

        [TestMethod]
        public void TestCheckPermutation()
        {
            Assert.AreEqual(true, Algorithm.CheckPermutation("a", "a"));
            Assert.AreEqual(false, Algorithm.CheckPermutation("a", "b"));
            Assert.AreEqual(true, Algorithm.CheckPermutation("ab", "ba"));
            Assert.AreEqual(true, Algorithm.CheckPermutation("abc", "cba"));
            Assert.AreEqual(false, Algorithm.CheckPermutation("abcc", "cba"));
            Assert.AreEqual(false, Algorithm.CheckPermutation("ab c", "cba"));
            Assert.AreEqual(true, Algorithm.CheckPermutation("abC", "cba"));
        }

        [TestMethod]
        public void TestURLify()
        {
            Assert.AreEqual("a", Algorithm.URLify("a"));

            //Assert.AreEqual("aasdfas", Algorithm.URLify("aasdfas"));
            //Assert.AreEqual("%20", Algorithm.URLify(" "));
            //Assert.AreEqual("%20%20", Algorithm.URLify("  "));


            //Assert.AreEqual("a%20a", Algorithm.URLify("a a"));
        }

    }
}
