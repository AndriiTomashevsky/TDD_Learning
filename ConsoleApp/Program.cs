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
            test.Name = test.TestTemplateMethod;
            test.Run(new TestResult());

            test = new TestCaseTest();
            test.Name = test.TestResult;
            test.Run(new TestResult());

            test = new TestCaseTest();
            test.Name = test.TestFailedResult;
            test.Run(new TestResult());

            test = new TestCaseTest();
            test.Name = test.TestFailedResultFormatting;
            test.Run(new TestResult());

            test = new TestCaseTest();
            test.Name = test.TestFailedSetUp;
            test.Run(new TestResult());

            test = new TestCaseTest();
            test.Name = test.TestSuit;
            test.Run(new TestResult());

            Console.ReadKey();
        }
    }
}
