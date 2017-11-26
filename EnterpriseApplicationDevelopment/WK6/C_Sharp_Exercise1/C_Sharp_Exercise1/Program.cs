using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercise1
{
    public abstract class PassMoney                                                                         //abstract class to hold abstract methods
    {
        public abstract void MakeDeposit(double amount);                                                    //add money to balance
        public abstract void MakeWithdrawl(double amount);                                                  //takeaway money from balance
    }

    class BankAccount : PassMoney
    {
        private int accountNumber;                                                                          //variables
        private double balance;

        public int AccountNumber                                                                            //properties
        {
            get
            {
                return this.accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public BankAccount(int accountNumberIn)                                                             //constructor
        {
            this.accountNumber = accountNumberIn;
            this.Balance = 0;
        }

        public override void MakeDeposit(double amount)
        {
            this.Balance += amount;
        }

        public override void MakeWithdrawl(double amount)
        {
            this.Balance -= amount;
        }
    }

    class CurrentAccount : BankAccount
    {
        private double overDraftLimit;                                                                      //variable

        public double OverDraftLimit                                                                        //property
        {
            get
            {
                return this.overDraftLimit;
            }
        }

        public CurrentAccount(int accountNumberIn):base(accountNumberIn)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
