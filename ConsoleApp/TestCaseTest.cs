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

        private void Assert(string wasRun)
        {
            Console.WriteLine(wasRun);
        }
    }
}
