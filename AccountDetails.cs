using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class AccountDetails
    {
        protected int accNo;
        protected string name;
        protected string accType;
        protected double balance;

        public void getData()
        {
            Console.WriteLine("Enter Account Number");
            accNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            accType = Console.ReadLine();
            Console.WriteLine("Enter Balance");
            balance = double.Parse(Console.ReadLine());
        }

        public Double checkBalance()
        {
            return this.balance;
        }

        public void deposit()
        {
            Console.WriteLine("Enter Amount");
            double amount = double.Parse(Console.ReadLine());
            this.balance = this.balance + amount;
            
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter Amount");
            double amount = double.Parse(Console.ReadLine());
            if (amount < this.balance)
            {
                this.balance = this.balance - amount;
            }
            else
                Console.WriteLine("Withdraw was greater then balance");
        }

        public Boolean checkAccount(int accNo)
        {
            if (this.accNo == accNo)
                return true;
            else
                return false;
        }

        public void displayAccountDetail()
        {
            Console.WriteLine();
            Console.WriteLine("Bank Account Number  = "+accNo);
            Console.WriteLine("Account Holder Name  = " + name);
            Console.WriteLine("Bank Account Type    = " + accType);
            Console.WriteLine("Balance of Account   = " + balance);
        }
    }
}
