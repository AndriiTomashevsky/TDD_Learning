using System;

namespace ConsoleApp
{
    //WasRun it's a test case that reports whether a method was run.
    public class WasRun : TestCase
    {
        public string log;

        public WasRun()
        {
        }

        internal void TestMethod()
        {
            log += " TestMethod";
        }

        public override void SetUp()
        {
            log = "SetUp";
        }

        public override void TearDown()
        {
            log += " TearDown";
        }

        internal void TestBrokenMethod()
        {
            throw new Exception();
        }

        internal void TestBrokenSetUp()
        {
            throw new Exception();
        }
    }
}