using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class BankApplication
    {
        static void Main(string[] args)
        {
            AccountDetails ob = new AccountDetails();
            int ch, accNo;
            do
            {
                Console.WriteLine("1. Create Account\n2. Display Account Details\n3. Current Balance" +
                    "\n4. Deposit\n5. Withdraw\n6 Exits\n");
                Console.WriteLine("Enter Your Choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        ob.getData();
                        break;
                    case 2:
                        Console.WriteLine("Enter Account Number");
                        accNo = int.Parse(Console.ReadLine());
                        if (ob.checkAccount(accNo))
                        {
                            ob.displayAccountDetail();
                        }
                        else
                            Console.WriteLine("Don't have a Account");
                        break;
                    case 3:
                        Console.WriteLine("Enter Account Number");
                        accNo = int.Parse(Console.ReadLine());
                        if (ob.checkAccount(accNo))
                        {
                            Console.WriteLine("Avaliable Balance is = " + ob.checkBalance());
                        }
                        else
                            Console.WriteLine("Don't have a Account");
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Number");
                        accNo = int.Parse(Console.ReadLine());
                        if (ob.checkAccount(accNo))
                        {
                            ob.deposit();
                        }
                        else
                            Console.WriteLine("Don't have a Account");
                        break;
                    case 5:
                        Console.WriteLine("Enter Account Number");
                        accNo = int.Parse(Console.ReadLine());
                        if (ob.checkAccount(accNo))
                        {
                            ob.Withdraw();
                        }
                        else
                            Console.WriteLine("Don't have a Account");
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Please Put valide option");
                        break;
                }
            } while (ch != 6);
        }
    }
}
