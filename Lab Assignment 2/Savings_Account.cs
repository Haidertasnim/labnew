using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class Savings_Account : Account
    {
        //Cannot withdraw if balance is zero
        //public Savings_Account(string name, double balance,string address, string dob)
            //: base(name, balance,address,dob){}

        public override void Withdraw(int amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " $ Withdrawn...");

                balance = balance - amount;

                Console.WriteLine("Current Balance is: " + balance);
            }
            else
            {
                Console.WriteLine("\nCannot Withdraw,Invalid Or Insufficient Amount...");
            }
        }

        public override void Show_Info()
        {
            Console.WriteLine("\nAccount Type: Savings Account");
            base.Show_Info();
        }
    }
}
