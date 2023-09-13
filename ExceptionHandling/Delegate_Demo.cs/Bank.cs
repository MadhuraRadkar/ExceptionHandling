using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Delegate_Demo.cs
{
    public delegate void Action();
    public class Bank
    {
        private double balance;
        public event Action InsufficientBalance;
        public event Action LowBalance;
        public event Action ZeroBalance;
        public Bank(double defaultBalance)
        {
            balance = defaultBalance;
        }
        public void Credit(double amount)
        {
            balance = balance + amount;
            if(balance < 3000)
            {
                LowBalance();
            }
        }
        public void Debit(double amount)
        {
            if(amount > balance)
            {
                InsufficientBalance();
            }
            balance = balance - amount;
            if(balance<3000)
            {
                LowBalance();
            }
            if(balance == 0)
            {
                ZeroBalance();
            }
        }
    }
    public class BankProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank(5000);
                bank.LowBalance += delegate () { Console.WriteLine("Low balance"); };
                bank.InsufficientBalance += delegate () { Console.WriteLine("Insufficient balance"); };
                bank.Debit(8000);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message );
            }
           
        }
    }

}
