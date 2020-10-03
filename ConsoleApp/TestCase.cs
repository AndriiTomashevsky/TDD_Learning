using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class TestCase
    {
        public Method Name { get; set; }
        public WasRun test;

        internal void Run()
        {
            SetUp();
            Method method = Name;
            method();
        }

        public abstract void SetUp();
    }
}
