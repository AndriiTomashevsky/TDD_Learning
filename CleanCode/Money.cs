using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Money : IExpression
    {
        public int amount;
        string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object obj)
        {
            return amount == ((Money)obj).amount
                && currency == ((Money)obj).currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public IExpression Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return $"{amount} {currency}";
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(amount / bank.Rate(currency, to), to);
        }
    }
}
