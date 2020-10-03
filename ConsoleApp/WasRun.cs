using System;

namespace ConsoleApp
{
    //WasRun it's a test case that reports whether a method was run.
    public class WasRun : TestCase
    {
        internal string wasRun;
        public string log;

        public WasRun()
        {
        }

        internal void TestMethod()
        {
            wasRun = $"{Name.Method.Name} was run";
            log += " TestMethod";
        }

        public override void SetUp()
        {
            wasRun = "None";
            log = "SetUp";
        }

        public override void TearDown()
        {
            log += " TearDown";
        }
    }
}