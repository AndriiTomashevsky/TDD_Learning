using System;

namespace ConsoleApp
{
    internal class TestResult
    {
        private int runCount;
        private int errorCount;

        public TestResult()
        {
            runCount = 0;
            errorCount = 0;
        }

        internal void TestStarted()
        {
            runCount += 1;
        }

        internal string Summary()
        {
            return $"{runCount} run, {errorCount} failed";
        }

        internal void TestFailed()
        {
            errorCount += 1;
        }

        internal void ResetCount()
        {
            runCount = 0;
        }
    }
}