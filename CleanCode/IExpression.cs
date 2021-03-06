﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Plus(IExpression tenFrancs);
        IExpression Times(int multiplier);
    }
}
