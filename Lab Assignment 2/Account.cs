using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
	public abstract class Account
	{
		protected string name;
		protected string dob;
		protected string address;
		protected double balance;
		protected static int acNum = 101;
		protected int accountNumber;

		public Account() { }

		public int AccNumber()
		{
			accountNumber = acNum;
			acNum++;
			return accountNumber;
		}
		public Account(string name, double balance,string address, string dob)
		{
			this.name = name;
			this.address = address;
			this.dob = dob;
			this.balance = balance;
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("Invalid Account Holder Name.");
					return;
				}
				this.name = value;
			}
		}

		public int AccountNumber
		{
			get
			{
				return accountNumber;
			}
			set
			{
				this.accountNumber = value;
			}
		}

		public double Balance
		{
			get
			{
				return balance;
			}
			set
			{
				this.balance = value;
			}
		}
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				this.address = value;
			}
		}
		public string DOB
		{
			get
			{
				return dob;
			}
			set
			{
				this.dob = value;
			}
		}
		public void Deposit(double amount)
		{
			Console.WriteLine("\nPrevious Balance was : "+balance);
			Console.WriteLine(+amount+ "$ Deposited...");
		
			balance = balance + amount;

			Console.WriteLine("Current Balance is : " + balance);
		}
		public abstract void Withdraw(int amount);

		public void Transfer(int amount,Account receiver)
		{
			if(amount<0)
			{
				Console.WriteLine("\nAmount can not be negative");
			}
			else if(balance>=amount)
			{
				Withdraw(amount);
				receiver.Deposit(amount);
				Console.WriteLine("\n" + name + " has transfered " + amount + " taka to " + receiver.name + "'s account");
			}
			else
			{
				Console.WriteLine("\nInsufficient Balance");
			}

			Console.WriteLine("\n" + name + "'s current balance is " + balance);
			Console.WriteLine(receiver.name + "'s current balance is " + receiver.balance);
		}

		public virtual void Show_Info()
		{
			Console.WriteLine("Account Holder Name: " + name);
			Console.WriteLine("Account Number: " + AccNumber());
			Console.WriteLine("Available Balance: " + balance);
			Console.WriteLine("Address: " + address);
			Console.WriteLine("Date Of Birth: " + dob);
		}
	}
}
