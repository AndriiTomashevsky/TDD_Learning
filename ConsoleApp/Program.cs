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
            test.Run();

            test = new TestCaseTest();
            test.Name = test.TestResult;
            test.Run();

            test = new TestCaseTest();
            test.Name = test.TestFailedResult;
            test.Run();

            test = new TestCaseTest();
            test.Name = test.TestFailedResultFormatting;
            test.Run();

            test = new TestCaseTest();
            test.Name = test.TestFailedSetUp;
            test.Run();


            Console.ReadKey();
        }
    }
}
