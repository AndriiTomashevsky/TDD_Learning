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
            //TestCaseTest test = new TestCaseTest();
            //test.Name = test.TestTemplateMethod;
            //test.Run(new TestResult());

            //test = new TestCaseTest();
            //test.Name = test.TestResult;
            //test.Run(new TestResult());

            //test = new TestCaseTest();
            //test.Name = test.TestFailedResult;
            //test.Run(new TestResult());

            //test = new TestCaseTest();
            //test.Name = test.TestFailedResultFormatting;
            //test.Run(new TestResult());

            //test = new TestCaseTest();
            //test.Name = test.TestFailedSetUp;
            //test.Run(new TestResult());

            //test = new TestCaseTest();
            //test.Name = test.TestSuit;
            //test.Run(new TestResult());

            //Console.ReadKey();

            for (int k = 1; k < 3; k++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        if ((k == 1 && (i == j || i == (9 - j))) || (k == 2 && (i == (5 - j) || i == (4 + j))))
                        {
                            Console.Write("@");
                        }
                        else
                        {
                            Console.Write("x");
                        }
                    }

                    Console.WriteLine();                }
            }

            Console.ReadKey();

        }
    }
}
