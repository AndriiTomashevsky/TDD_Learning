using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class TestSuit
    {
        List<WasRun> tests;

        public TestSuit()
        {
            tests = new List<WasRun>();
        }

        internal void Add(WasRun wasRun)
        {
            tests.Add(wasRun);
        }

        internal void Run(TestResult result)
        {
            foreach (var test in tests)
            {
                test.Run(result);
            }
        }
    }
}