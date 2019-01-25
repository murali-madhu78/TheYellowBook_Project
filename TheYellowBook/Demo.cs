using System;

namespace TheYellowBook
{
    enum AccountState
    {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed
    }

    //struct Account
    //{
    //    public AccountState State;
    //    public string Name;
    //    public string Address;
    //    public int AccountNumber;
    //    public int Balance;
    //    public int OverDraft;
    //}

    class Demo
    {
        static void Main()
        {
            Console.WriteLine("Yellow Book Demo \n");
            #region Enum Example
            //AccountState account_status;
            //account_status = AccountState.Active;
            //Console.WriteLine("Enumerations Status: " + account_status);
            #endregion
            Account.MinAge = 18;
            Account.MinIncome = 10000;

            Account RobsAccount = new Account
            {
                Name = "Rob Miles",
                AccountNumber = 12345,
                Address = "Nowhere",
                State = AccountState.Active,
                OverDraft = 0
            };

            const int MAX_CUST = 100;
            IAccount[] Bank = new IAccount[MAX_CUST];
            //Bank[0] = new Account();
            Bank[0] = RobsAccount;
            //Console.WriteLine("Structure - Name : " + Bank[0].Name + " has an " + Bank[0].State + " bank account with balance " + Bank[0].Balance);
            RobsAccount.PayInFunds(300);
            bool canWithdraw = RobsAccount.WithdrawFunds(20);
            decimal bal = RobsAccount.GetBalance();
            void PrintAccount(IAccount a)
            {
                Console.WriteLine("\nName: " + a.Name + "\n");
                Console.WriteLine("Acc Number: " + a.AccountNumber + "\n");
                Console.WriteLine("Balance: " + a.GetBalance().ToString() + "\n");
                Console.WriteLine("Account Status: " + a.State + "\n");
            }

            Console.ReadLine();
        }
    }
}
