using System;

namespace ConsoleApp
{
    internal class WasRunSetUpFailed : TestCase
    {
        public string log;

        public WasRunSetUpFailed()
        {
        }

        internal void TestMethod()
        {
            log += " TestMethod";
        }

        public override void SetUp()
        {
            throw new Exception();
        }

        public override void TearDown()
        {
            log += " TearDown";
        }
    }
}