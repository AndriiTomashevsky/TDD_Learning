using System;

namespace ConsoleApp
{
    //WasRun it's a test case that reports whether a method was run.
    internal class WasRun : TestCase
    {
        internal string wasRun;

        public WasRun()
        {
            wasRun = "None";
        }

        internal void TestMethod()
        {
            wasRun = $"{Name.Method.Name} was run";
        }
    }
}