using BankPA.BankAccounts;
using BankPA.Clients;
using BankPA.Stocks;
using BankPA.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPA
{
    public class Bank
    {
        public List<Client> Clients { get; set; }
        public List<Account> Accounts { get; set; }

        private double InterestRate { get; }
        private double Commision {  get; }

        public Bank() 
        {
            Clients = new List<Client>();
            Accounts = new List<Account>();
            InterestRate = 0.02;
            Commision = 0.03;
        }

        public void CustomerRegistration(Client client)
        {
            Clients.Add(client);
        }

        public void OpenAccoutForClient(Client client, AccountType accountType) 
        {
            if (client == null) 
            {
                throw new ArgumentNullException("Please provide the customer for whom the account is to be created. ");
            }
            else
            {
                if(accountType == AccountType.Savings)
                {
                    SavingsAccount account = new SavingsAccount("1111 2222 3333 4444 5555 6666", InterestRate, client);
                    client.SavingsAccounts.Add(account);
                }
                else if (accountType == AccountType.Investments)
                {
                    InvestmentsAccount account = new InvestmentsAccount("1100 2233 4455 6677 8899", client);
                    client.InvestmentsAccounts.Add(account);
                }
            }
        }

        public void CalculateInterestForClinet(Client client, int accountIndex)
        {
            client.SavingsAccounts[accountIndex].CalculateInterest();
        }

        public void ShowInterestValue(Client client, int accountIndex)
        {
            Console.WriteLine(client.SavingsAccounts[accountIndex].ShowInterestValue());
        }

        public void Deposit(Client client, Util.AccountType accountType, int indexAccount, double deposit)
        {
             client.DepositIntoAccout(accountType, indexAccount, deposit);
            
        }

        public void BuyStockForClient(Client client, Stock stock, int accountIndex, int count)
        {
            client.BuyStock(stock, 0, 5, Commision);
        }

        public void ShowAccountBallance(Client client, Util.AccountType accountType, int accountIndex)
        {
            client.CheckAccountBalance(accountType, accountIndex);
        }
        
    }
}
