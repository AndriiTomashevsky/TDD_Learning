using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Money : IExpression
    {
        int amount;
        string currency;

        Money(int amount, string currency)
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

        public Money Times(int multiplier)
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

        public IExpression Plus(Money money)
        {
            return Money.Dollar(amount + money.amount);
        }
    }
}
