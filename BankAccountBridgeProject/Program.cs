using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Monica = new Client("Monica", "Johnson", "Cleveland");
            Client Marty = new Client("Marty", "Kent", "Boston Heights");
            Console.WriteLine("Please select from the following menu options:");
            Console.WriteLine("1. View client information.");
            Console.WriteLine("2. View account balance.");
            Console.WriteLine("3. Deposit funds.");
            Console.WriteLine("4. Withdraw funds.");
            Console.WriteLine("5. Exit");

            Checking MartyK = new Checking(1234, 34.50, 10.00, 0, 0, 0);
            Savings MonicaJ = new Savings(4567, 20.50, 13.00, 0, 0, 0);
            Console.WriteLine("Your account number is {0}. ", MartyK.AccountNumber);
            Console.WriteLine("Your account number is {0}.", MonicaJ.AccountNumber);
            int userResponse = int.Parse(Console.ReadLine());


            do
            {

                switch (userResponse)
                {

                    case 1:
                        Console.WriteLine("a. Checking account");
                        Console.WriteLine("b. Savings account ");
                        string answerInfo = Console.ReadLine().ToLower();


                        if (answerInfo == "a")
                        {
                            Console.WriteLine(Monica.GetInfo());
                        }

                        if(answerInfo == "b")
                        {
                            Console.WriteLine(Marty.GetInfo());
                        }

                        break;

                    case 2:
                        Console.WriteLine("a. Checking account");
                        Console.WriteLine("b. Savings account");
                        string answerBal = Console.ReadLine().ToLower();
                        if (answerBal == "a")
                        {
                            Console.WriteLine(MartyK.GetBalance());
                        }

                        if (answerBal == "b")
                        {
                            Console.WriteLine(MonicaJ.GetBalance());
                        }
                        break;

                    case 3:
                        Console.WriteLine(MartyK.Deposit());
                        break;

                    case 4:
                        Console.WriteLine("a. Checking account");
                        Console.WriteLine("b. Savings account");
                        string answerWithdrawal = Console.ReadLine().ToLower();
                        if (answerWithdrawal == "a")
                        {
                            Console.WriteLine(MartyK.Withdrawal());
                        }

                        if (answerWithdrawal == "b")
                        {
                            Console.WriteLine(MonicaJ.Withdrawal());
                        }
                        break;

                    case 5:
                        break;
                }
            }
            while (userResponse != 5);
        }
    }
}
