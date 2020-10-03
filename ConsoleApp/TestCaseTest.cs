using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  public  class TestCaseTest : TestCase
    {
        public override void SetUp()
        {
            test = new WasRun();
            test.Name = test.TestMethod;
        }

        public void TestRunning()
        {
            test.Run();
            Assert(test.wasRun);
        }

        public void TestSetUp()
        {
            test.Run();
            Assert(test.wasSetUp); 
        }

        private void Assert(string wasRun)
        {
            Console.WriteLine(wasRun);
        }
    }
}
