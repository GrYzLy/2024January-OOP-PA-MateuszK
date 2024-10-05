using BankPA.BankAccounts;
using BankPA.Clients;
using BankPA.Stocks;

namespace BankPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Client c1 = new Client("Jan", "Kowalski", "ul. Jana Pawła 34/23, 00-001 Warszawa");

            bank.CustomerRegistration(c1);

            foreach (var client in bank.Clients) { Console.WriteLine("Registered Bank Customer " + client.Name + " " + client.Surname); }

            bank.OpenAccoutForClient(c1, Util.AccountType.Savings);

            foreach (var account in c1.SavingsAccounts) { Console.WriteLine("Registered Customer Savings Accounts \n" + account.ToString()); }

            bank.Deposit(c1, Util.AccountType.Savings, 0, 500);

            bank.CalculateInterestForClinet(c1, 0);
            

            Stock s = new Stock("Orlen", 20);

            bank.OpenAccoutForClient(c1, Util.AccountType.Investments);

            foreach (var account in c1.InvestmentsAccounts) { Console.WriteLine("Registered Customer Investmens Accounts \n" + account.ToString()); }

            bank.Deposit(c1, Util.AccountType.Investments, 0, 1000);

            bank.ShowAccountBallance(c1, Util.AccountType.Investments, 0);

            bank.BuyStockForClient(c1, s, 0, 10);

            bank.ShowAccountBallance(c1, Util.AccountType.Investments, 0);



        }
    }
}
