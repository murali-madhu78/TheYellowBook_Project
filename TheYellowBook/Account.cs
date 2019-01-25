using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheYellowBook
{
    class Account : IAccount
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

        //public static decimal MinIncome { get => minIncome; set => minIncome = value; }
        //public static int MinAge { get => minAge; set => minAge = value; }

        public Account()
        {
            Console.WriteLine("\nAccount Class Constructor\n");
        }

        public static bool AccountAllowed(decimal income, int age)
        {
            if (income >= MinIncome && age >= MinAge)
            { return true; }
            else
            { return false; }
        }

        public bool WithdrawFunds(decimal amount)
        {
            if (amount >= Balance && Balance < -10)
            {
                return false;
            }
            Balance = Balance - amount;
            return true;
        }

        public void PayInFunds(decimal amount)
        {
            Balance = Balance + amount;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void PrintAccount(IAccount a)
        {
            Console.WriteLine("\nName: " + a.Name + "\n");
            Console.WriteLine("Acc Number: " + a.AccountNumber + "\n");
            Console.WriteLine("Balance: " + a.GetBalance().ToString() + "\n");
            Console.WriteLine("Account Status: " + a.State + "\n");
        }
    }
}
