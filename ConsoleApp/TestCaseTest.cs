using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TestCaseTest : TestCase
    {
        public void TestTemplateMethod()
        {
            WasRun test = new WasRun();
            test.Name = test.TestMethod;
            test.Run();
            Assert($"{"SetUp TestMethod TearDown" == test.log}");
        }

        public void TestResult()
        {
            WasRun test = new WasRun();
            test.Name = test.TestMethod;
            TestResult result = test.Run();
            Assert($"{"1 run, 0 failed" == result.Summary()}");
        }

        public void TestFailedResult()
        {
            WasRun test = new WasRun();
            test.Name = test.TestBrokenMethod;
            TestResult result = test.Run();
            Assert($"{"1 run, 1 failed" == result.Summary()}");
        }

        public void TestFailedResultFormatting()
        {
            TestResult result = new TestResult();
            result.TestStarted();
            result.TestFailed();
            Assert($"{"1 run, 1 failed" == result.Summary()}");
        }

        public void TestFailedSetUp()
        {
            WasRunSetUpFailed test = new WasRunSetUpFailed();
            test.Name = test.TestMethod;

            var result = test.Run();
            Assert($"{"0 run, 0 failed" == result.Summary()}");
        }

        private void Assert(string wasRun)
        {
            Console.WriteLine(wasRun);
        }
    }
}
