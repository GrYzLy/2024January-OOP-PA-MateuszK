using BankPA.Clients;
using BankPA.Stocks;
using BankPA.Util;


namespace BankPA.BankAccounts
{
    public class InvestmentsAccount : Account, IAccount
    {
        public override double Ballance { get; protected set; }

        public override string AccountNumber { get; }

        public override AccountType Type { get; }

        public override Client Owner { get; }

        public List<Stock> Stocks { get; }

        public InvestmentsAccount(string accountNumber, Client owner)
        {
            AccountNumber = accountNumber;
            Ballance = 0;
            Type = AccountType.Investments;
            Owner = owner;
            Stocks = new List<Stock>();

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

        public void BuyStock(Stock stock, int count, double commision)
        {
            double TransactionValue = (stock.Value * count);
            TransactionValue += TransactionValue * commision;
            if (TransactionValue > Ballance)
            {
                throw new Exception("There are not enough funds on hand to complete this transaction ");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Stocks.Add(stock);
                    double singleTransactionValue = (stock.Value * commision) + stock.Value;
                    WithdrawFromAccount(singleTransactionValue);
                }
            }
        }

        public override string ToString()
        {
            return "Account Number: " + AccountNumber + "\n" + "AccountType " + Type + "\n" + "Account Owner " + Owner.ToString();
        }
    }
}
