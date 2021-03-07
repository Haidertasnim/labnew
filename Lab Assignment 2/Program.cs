using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings_Account sa = new Savings_Account();
            Checking_Account ca = new Checking_Account();

            string option, input1, input2;

            int choice1, choice2, choice3, choice4;

            int sva = 0;
            int cha = 0;


            do
            {
                Console.WriteLine("'open'");
                Console.WriteLine("'account'");
                Console.WriteLine("'quit'");

                Console.WriteLine("Please enter any choice To Start:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "open":
                    do
                    {
                            Console.WriteLine("'savings'");
                            Console.WriteLine("'checking'");
                            Console.WriteLine("'quit'");

                            Console.WriteLine("Please enter a command");
                            input1 = Console.ReadLine();

                            switch (input1)
                            {
                                case "savings":

                                Console.WriteLine("Enter Account Holder Name:");
                                string name1 = Console.ReadLine();                                    

                                Console.WriteLine("Enter Date of Birth:");
                                string dob1 = Console.ReadLine();                                  

                                Console.WriteLine("Enter Address:");
                                string address1 = Console.ReadLine();

                                Console.WriteLine("Enter Initial Balance:");
                                double balance1 = Convert.ToDouble(Console.ReadLine());

                                //Console.WriteLine("Account Number: " + sa.AccNumber());

                                sa.Name = name1;
                                sa.DOB = dob1;
                                sa.Address = address1;
                                sa.Balance = balance1;

                                Console.WriteLine(" Savings Account successfully created");
                                sva++;
                                break;

                                case "checking":

                                Console.WriteLine("Enter Account Holder Name:");
                                string name2 = Console.ReadLine();                                    

                                Console.WriteLine("Enter Date of Birth:");
                                string dob2 = Console.ReadLine();                                  

                                Console.WriteLine("Enter Address:");
                                string address2 = Console.ReadLine();

                                Console.WriteLine("Enter Initial Balance:");
                                double balance2 = Convert.ToDouble(Console.ReadLine());

                                //Console.WriteLine("Account Number: " + sa.AccNumber());

                                sa.Name = name2;
                                sa.DOB = dob2;
                                sa.Address = address2;
                                sa.Balance = balance2;

                                Console.WriteLine("Checking Account successfully created");
                                cha++;
                                break;

                                default:
                                Console.WriteLine("Invalid Option!! Enter Again...");
                                break;
                            }
                    }
                    while (input1 != "quit");
                    break;

                    case "account":
                    do
                    {
                            Console.WriteLine("deposit");
                            Console.WriteLine("withdraw");
                            Console.WriteLine("transfer");
                            Console.WriteLine("show");
                            Console.WriteLine("quit");

                            input2 = Console.ReadLine();

                            switch (input2)
                            {
                                case "deposit":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Deposite amount to savings account");
                                        Console.WriteLine("2.Deposite amount to checking account");
                                        Console.WriteLine("3.Back");

                                        choice1 = Convert.ToInt32(Console.ReadLine());

                                        switch (choice1)
                                        {
                                            case 1:
                                                if (sva == 0)
                                                {
                                                    Console.WriteLine("There is no savings account"); 
                                                }
                                                else
                                                {
                                                    Console.WriteLine("insert deposite amount for savings account:");
                                                    int amount1 = Convert.ToInt32(Console.ReadLine());
                                                    sa.Deposit(amount1);
                                                }
                                                break;

                                            case 2:
                                                if (cha == 0)
                                                {
                                                    Console.WriteLine("There is no checking account");
                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("insert deposite amount for checking account:");
                                                    int amount2 = Convert.ToInt32(Console.ReadLine());
                                                    ca.Deposit(amount2);
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Option!! Enter Again...");
                                                break;
                                        }
                                    }
                                    while (choice1 != 3);
                                    break;

                                case "withdraw":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Withdraw amount to savings account");
                                        Console.WriteLine("2.Withdraw amount to checking account");
                                        Console.WriteLine("3.Back");

                                        choice2 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice2)
                                        {
                                            case 1:
                                                if (sva == 0)
                                                {
                                                    Console.WriteLine("There is no savings account"); 
                                                }
                                                else
                                                {
                                                    Console.WriteLine("insert withdraw amount for savings account:");
                                                    int amount1 = Convert.ToInt32(Console.ReadLine());
                                                    sa.Withdraw(amount1);
                                                }
                                                break;

                                            case 2:
                                                if (cha == 0)
                                                {
                                                    Console.WriteLine("There is no checking account");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("insert withdraw amount for checking account:");
                                                    int amount2 = Convert.ToInt32(Console.ReadLine());
                                                    ca.Withdraw(amount2);
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Option!! Enter Again...");
                                                break;
                                        }
                                    }
                                    while (choice2 != 3);
                                    break;

                                case "transfer":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Transfer from savings account to checking account");
                                        Console.WriteLine("2.Transfer from checking account to savings account");
                                        Console.WriteLine("3.Back");

                                        choice3 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice3)
                                        {
                                            case 1:
                                                if (sva == 0 && cha == 0)
                                                {
                                                    Console.WriteLine("Either checking or savings or both accounts are not created");
                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Enter amount you want to transfer to checking account");
                                                    int amount1 = Convert.ToInt32(Console.ReadLine());

                                                    ca.Transfer(amount1,sa);
                                                }
                                                break;

                                            case 2:
                                                if (sva == 0 && cha == 0)
                                                {
                                                    Console.WriteLine("Either checking or savings or both accounts are not created");
                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Enter amount you want to transfer to savings account");
                                                    int amount2 = Convert.ToInt32(Console.ReadLine());

                                                    sa.Transfer(amount2, ca);
                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Invalid Option!! Enter Again...");
                                                break;
                                        }
                                    } 
                                    while (choice3 != 3);
                                    break;

                                case "show":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Show the saving account information");
                                        Console.WriteLine("2.Show the checking account information");
                                        Console.WriteLine("3.Back");

                                        choice4 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice4)
                                        {
                                            case 1:

                                                sa.Show_Info();
                                                break;

                                            case 2:

                                                ca.Show_Info();
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Option!! Enter Again...");
                                                break;
                                        }
                                    } 
                                    while (choice4 != 3);
                                    break;
                            }
                    }
                    while (input2 != "quit");

                    break;
                }
            }
            while (option != "quit");
        }
    }
}
