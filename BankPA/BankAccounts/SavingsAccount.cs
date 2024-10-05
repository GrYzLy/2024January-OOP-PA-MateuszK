using BankPA.Clients;
using BankPA.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA.BankAccounts
{
    public class SavingsAccount : Account, IAccount
    {
        public override double Ballance { get; protected set; }
        public override string AccountNumber { get; }
        public override AccountType Type { get; }
        public double InterestRate { get; }
        private double Interest;

        public override Client Owner { get; }

        public SavingsAccount(string accountNumber, double interestRate, Client clinet)
        {
            Ballance = 0;
            AccountNumber = accountNumber;
            Type = AccountType.Savings;
            InterestRate = interestRate;
            Owner = clinet;
            Interest = 0;
        }

        public double DepositIntoAccount(double ammout)
        {
            Ballance += ammout;
            return Ballance;
        }

        public double WithdrawFromAccount(double ammout)
        {
            Ballance -= ammout;
            return Ballance;
        }

        public void CalculateInterest()
        {
            Interest += (Ballance * InterestRate);
            Ballance += Interest;
        }

        public double ShowInterestValue()
        {
            return Interest;
        }

        public override string ToString()
        {
            return "Account Number: " + AccountNumber + "\n" + "AccountType " + Type + "\n" + "Account Owner " + Owner.ToString();
        }
    }
}
