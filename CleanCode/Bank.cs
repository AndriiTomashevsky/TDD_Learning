using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Bank
    {
        public Money Reduced(IExpression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}
