using System;

namespace EncapsulationDemo
{
    public class BankAccount
    {

        private string AccountHolderName;
        private double Balance;

        public void checkBalance()
        {
            Console.WriteLine($"Mr.{AccountHolderName} your current balance is : {Balance}");
        }

        public void Deposit(double val)
        {
            if (val > 0)
            {
                Balance += val;
                Console.WriteLine("Amount added successfully");
            }
            else
            {
                Console.WriteLine("Please enter a valid amount");
            }
        }

        public void withDraw(double val)
        {
            if (Balance < val)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= val;
                Console.WriteLine($"Withdraw successful. Your current balance is : {Balance}");
            }
        }

        public void createAccount(string username, double amount)
        {
            if (!string.IsNullOrEmpty(username) && amount > 0)
            {
                AccountHolderName = username;
                Balance = amount;
                Console.WriteLine("Account created successfully");
                Console.WriteLine($"Thank you Mr.{AccountHolderName} !!");
            }
            else
            {
                Console.WriteLine("Please enter a valid name and amount");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount();
            myBank.createAccount("Priyan Vishwakarma", 20000);
            myBank.checkBalance();
            myBank.Deposit(5000);
            myBank.checkBalance();
            myBank.withDraw(20000);
        }
    }
}
