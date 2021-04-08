using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace изучение_классов
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<Maxim Lancev>", 1000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} with {account.Balance} initial balance");
            Console.ReadKey();
            account.MAkeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MAkeWithdrawal(750, DateTime.Now, "Attempt of overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
               
            }

            Console.WriteLine(account.GetAccountHistory());
            Console.ReadKey();

        }
    }
}
