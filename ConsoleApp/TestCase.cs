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

        internal TestResult Run()
        {
            TestResult result = new TestResult();
            result.TestStarted();

            try
            {
                SetUp();
            }
            catch (Exception)
            {
                result.ResetCount();

                return result; 
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

            return result;
        }

        public virtual void TearDown() { }
        public virtual void SetUp() { }
    }
}
