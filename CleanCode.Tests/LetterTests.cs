using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class LetterTests
    {
        [TestMethod]
        public void TestX()
        {
            Assert.AreEqual(@"
@xxxxxx@
x@xxxx@x
xx@xx@xx
xxx@@xxx
xxx@@xxx
xx@xx@xx
x@xxxx@x
@xxxxxx@
", Letter.X());
        }

        [TestMethod]
        public void TestX2()
        {
            Assert.AreEqual(@"
@xxxxxx@
x@xxxx@x
xx@xx@xx
", Letter.X2());
        }

    }
}
