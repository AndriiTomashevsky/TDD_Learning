using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TestCaseTest : TestCase
    {
        public override void SetUp()
        {
            result = new TestResult();
        }

        public void TestTemplateMethod()
        {
            WasRun test = new WasRun();
            test.Name = test.TestMethod;

            test.Run(result);

            Assert($"{"SetUp TestMethod TearDown" == test.log}");
        }

        public void TestResult()
        {
            WasRun test = new WasRun();
            test.Name = test.TestMethod;

            test.Run(result);

            Assert($"{"1 run, 0 failed" == result.Summary()}");
        }

        public void TestFailedResult()
        {
            WasRun test = new WasRun();
            test.Name = test.TestBrokenMethod;

            test.Run(result);

            Assert($"{"1 run, 1 failed" == result.Summary()}");
        }

        public void TestFailedResultFormatting()
        {
            result.TestStarted();
            result.TestFailed();

            Assert($"{"1 run, 1 failed" == result.Summary()}");
        }

        public void TestFailedSetUp()
        {
            WasRunSetUpFailed test = new WasRunSetUpFailed();
            test.Name = test.TestMethod;

            test.Run(result);

            Assert($"{"0 run, 0 failed" == result.Summary()}");
        }

        public void TestSuit()
        {
            TestSuit suit = new TestSuit();
            suit.Add(new WasRun() { Name = (new WasRun()).TestMethod });
            suit.Add(new WasRun() { Name = (new WasRun()).TestBrokenMethod });

            TestResult result = new TestResult();
            suit.Run(result);

            Assert($"{"2 run, 1 failed" == result.Summary()}");
        }

        private void Assert(string wasRun)
        {
            Console.WriteLine(wasRun);
        }
    }
}
