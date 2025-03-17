using System;
namespace EncsapsulationAndAbstract
{
    abstract class saymyname
    {
        public abstract void Username();
    }

    class BankAccount : saymyname
    {
        public override void Username()
        {
            Console.WriteLine("hellow !!");
        }

        private decimal UserBalance;

        public decimal Balance
        {
            get { return UserBalance; }
            set
            {
                if (value >= 0)
                {
                    UserBalance = value;
                }
                else
                {
                    Console.WriteLine($"Enter a valid amount, entered value is: {value}");
                }
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposit successful!!");
            }
            else
            {
                Console.WriteLine("Enter an amount greater than 0");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Rs{amount} withdrawal successful!!! Your current balance is: {UserBalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {UserBalance}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Balance = -1000;

            account.Deposit(500);

            account.Withdraw(200);
            account.CheckBalance();

            account.Withdraw(1500);
            account.CheckBalance();
            account.Username();
        }
    }
}

