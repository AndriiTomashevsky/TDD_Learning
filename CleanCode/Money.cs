using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;

            return amount == money.amount && GetType().Equals(obj.GetType());
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public abstract Money Times(int amount);

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }
    }
}
