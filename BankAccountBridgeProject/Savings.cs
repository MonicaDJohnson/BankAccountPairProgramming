using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    public class Savings : Account

    {
        public Savings(int accountNumber, double balance, double makeDepositOrWithdrawal, double interest, double interestRate, double newBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.AccountType = AccountType;
            this.MakeDepositOrWithdrawal = makeDepositOrWithdrawal;
            this.Interest = interest;
            this.InterestRate = interestRate;
            this.NewBalance = newBalance;
        }
            

       


        public override double IntRate()
        {
            InterestRate = .03;
            return NewBalance;

        }


        public override void Transactions()
        {
            throw new NotImplementedException();
        }

    }

    
}
