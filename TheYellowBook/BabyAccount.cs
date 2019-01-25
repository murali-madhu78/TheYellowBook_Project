using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheYellowBook
{
    public class BabyAccount : IAccount
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        private decimal Balance = 0;
        public int OverDraft;
        public static decimal InterestRateCharged = 10;
        private static decimal minIncome;
        private static int minAge;

        private decimal balance = 0;
        public bool WithdrawFunds(decimal amount)
        {
            if(amount > 10 || balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }

        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void PrintAccount(BabyAccount a)
        {
            Console.WriteLine("\nName: " + a.Name + "\n");
            Console.WriteLine("Acc Number: " + a.AccountNumber + "\n");
            Console.WriteLine("Balance: " + a.GetBalance().ToString() + "\n");
            Console.WriteLine("Account Status: " + a.State + "\n");
        }
    }
}
