using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Sum : IExpression
    {
        public Money augent;
        public Money addend;

        public Sum(Money augent, Money addend)
        {
            this.augent = augent;
            this.addend = addend;
        }

        public Money Reduce(string to)
        {
            return new Money(augent.amount + addend.amount, to);
        }
    }
}
