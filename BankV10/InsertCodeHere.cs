using System;

namespace BankV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount account = new BankAccount();
            Console.WriteLine($"Balance is {account.Balance}");

            account.Deposit(1000);
            Console.WriteLine($"Balance is {account.Balance} after depositing 1000");
            account.Withdraw(1001);
            Console.WriteLine($"Balance is {account.Balance} after withdrawwing 1001 ---- Error, withdraw is larger than balance ---");
            account.Withdraw(999);
            Console.WriteLine($"Balance is {account.Balance} after withdrawwing 999");
            

            account.Deposit(-1000);
            Console.WriteLine($"Balance is {account.Balance} after depositing -1000 ---- Error, cannot deposit minus nubmers ---");
            account.Withdraw(-1000);
            Console.WriteLine($"Balance is {account.Balance} after withdrawwing -1000 ---- Error, cannot withdraw minus nubmers ---");

            // The LAST line of code should be ABOVE this line
        }
    }
}