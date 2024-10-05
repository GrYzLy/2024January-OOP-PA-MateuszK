using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA.BankAccounts
{
    public interface IAccount
    {
        public double DepositIntoAccount(double ammout);
        public double WithdrawFromAccount(double ammout);
    }
}
