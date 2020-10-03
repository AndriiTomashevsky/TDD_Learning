using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public delegate void Method();

    public class Program
    {
        static void Main(string[] args)
        {
            //WasRun it's a test case that reports whether a method was run.
            TestCaseTest test = new TestCaseTest();
            test.Name = test.TestRunning;
            test.Run();

            test = new TestCaseTest();
            test.Name = test.TestSetUp;
            test.Run();

            Console.ReadKey();
        }
    }
}
