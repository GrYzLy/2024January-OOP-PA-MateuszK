using BankPA.BankAccounts;
using BankPA.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA.Clients
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public List<SavingsAccount> SavingsAccounts { get; set; }
        public List<InvestmentsAccount> InvestmentsAccounts { get; set; }

        public Client(string name, string surname, string address)
        {
            Name = name;
            Surname = surname;
            Address = address;
            SavingsAccounts = new List<SavingsAccount>();
            InvestmentsAccounts = new List<InvestmentsAccount>();
        }

        public override string ToString() 
        { 
            return "Customer Details: " + "\n" + Name + " " + Surname + "\n" + Address;
        }

        public void DepositIntoAccout(Util.AccountType accountType, int indexAccount, double deposit)
        {
            if(accountType == Util.AccountType.Savings)
            {
                SavingsAccount account = (SavingsAccount)SavingsAccounts[indexAccount];
                account.DepositIntoAccount(deposit);
            }
            else
            {
                InvestmentsAccount account = (InvestmentsAccount)InvestmentsAccounts[indexAccount];
                account.DepositIntoAccount(deposit);
            }

        }

        public void WithdrawalFromAccount(Util.AccountType accountType, int indexAccount, double withdrawal)
        {
            if (accountType == Util.AccountType.Savings)
            {
                SavingsAccount account = (SavingsAccount)SavingsAccounts[indexAccount];
                account.WithdrawFromAccount(withdrawal);
            }
            else
            {
                InvestmentsAccount account = (InvestmentsAccount)InvestmentsAccounts[indexAccount];
                account.WithdrawFromAccount(withdrawal);
            }
        }

        public void CheckAccountBalance(Util.AccountType accountType, int indexAccount)
        {
            if (accountType == Util.AccountType.Savings)
            {
                Console.WriteLine("Ballance Account: " + SavingsAccounts[indexAccount].Ballance);
            }
            else
            {
                Console.WriteLine("Ballance Account: " + InvestmentsAccounts[indexAccount].Ballance);
            }
            
        }

        public void BuyStock(Stock stock, int indexAccount, int count, double commision) 
        {
            InvestmentsAccount investmentsAccounts = InvestmentsAccounts[indexAccount];
            investmentsAccounts.BuyStock(stock, count, commision);
        }

        
    }
}
