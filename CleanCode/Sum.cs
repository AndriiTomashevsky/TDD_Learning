using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Sum : IExpression
    {
        public IExpression augent;
        public IExpression addend;

        public Sum(IExpression augent, IExpression addend)
        {
            this.augent = augent;
            this.addend = addend;
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(augent.Reduce(bank, to).amount + addend.Reduce(bank, to).amount, to);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(augent.Times(multiplier), addend.Times(2));
        }
    }
}
