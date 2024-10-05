using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA.Stocks
{
    public class Stock
    {
        public string Name { get; }
        public double Value { get; }

        public Stock(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
