using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    public abstract class Account

    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public double MakeDepositOrWithdrawal { get; set; }
        public double Interest { get; set; }
        public double InterestRate { get; set; }
        public double NewBalance { get; set; }
       



        public Account()
        {

        }

        public abstract void Transactions();

         public virtual double GetBalance()
        {
            return Balance;
        }

        public virtual double Deposit()
        {
            Balance = Balance + MakeDepositOrWithdrawal;
            return Balance;
           
        }

        public virtual double Withdrawal()
        {
            Balance = Balance - MakeDepositOrWithdrawal;
            return Balance;
        }

        public virtual double IntRate()
        {
            Interest = Balance * InterestRate;
            NewBalance = Balance + Interest;
            return NewBalance;
        }


        public virtual double NewBal()
        {
            return NewBalance;
        }

        

    }
}
