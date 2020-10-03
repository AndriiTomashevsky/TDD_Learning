using System;

namespace ConsoleApp
{
    //WasRun it's a test case that reports whether a method was run.
    public class WasRun : TestCase
    {
        internal string wasRun;
      public  string wasSetUp;

        public WasRun()
        {
        }

        internal void TestMethod()
        {
            wasRun = $"{Name.Method.Name} was run";
        }

        public override void SetUp()
        {
            wasRun = "None";
            wasSetUp = $"{Name.Method.Name} was set up";
        }

    }
}