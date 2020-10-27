using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TestCase
    {
        public Method Name { get; set; }
        protected TestResult result;

        internal void Run(TestResult result)
        {
            result.TestStarted();

            try
            {
                SetUp();
            }
            catch (Exception)
            {
                result.ResetCount();
            }

            Method method = Name;

            try
            {
                method();
            }
            catch (Exception)
            {
                result.TestFailed();
            }

            TearDown();
        }

        public virtual void TearDown() { }
        public virtual void SetUp() { }
    }
}
