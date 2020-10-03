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

        internal void Run()
        {
            SetUp();
            Method method = Name;
            method();
            TearDown();
        }

        public virtual void TearDown() { }
        public virtual void SetUp() { }
    }
}
