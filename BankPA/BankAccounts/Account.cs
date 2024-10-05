using BankPA.Clients;
using BankPA.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankPA.BankAccounts
{
    public abstract class Account
    {
        public abstract double Ballance {  get; protected set; }
        public abstract string AccountNumber { get; }
        public abstract AccountType Type { get; }

        public abstract Client Owner { get; }
    }
}
