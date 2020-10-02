using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TestCaseTest : TestCase
    {
        public void TestRunning()
        {
            //WasRun it's a test case that reports whether a method was run.
            WasRun test = new WasRun();
            test.Name = test.TestMethod;

            Assert(test.wasRun); // None

            //Next we need to use our real interface, run(), instead of calling the test method directly.
            //test.TestMethod();
            test.Run();

            Assert(test.wasRun); // Was run

        }

        private void Assert(string wasRun)
        {
            Console.WriteLine(wasRun);
        }
    }
}
