/*02. A bank holds different types of accounts for its customers: 
* deposit accounts, loan accounts and mortgage accounts. Customers 
* could be individuals or companies. 	
* All accounts have customer, balance and interest rate (monthly based). 
* Deposit accounts are allowed to deposit and with draw money. 
* Loan and mortgage accounts can only deposit money.
* All accounts can calculate their interest amount for a given period (in months). 
* In the common case its is calculated as follows: number_of_months * interest_rate. 
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
    }
}

public enum CustomerType
{
    Company,
    Individuals
}

abstract public class Account
{
    protected string customer;
    protected decimal balance;
    protected decimal interestRate;
    public CustomerType accountType;
    
    public decimal Balance
    {
        get
        {
            return this.balance;
        }
        protected set
        {
            this.balance = value;
        }
    }

    public Account(string customer, CustomerType type, decimal balance, decimal interestRate)
    {
        this.customer = customer;
        this.Balance = balance;
        this.accountType = type;
        this.interestRate = interestRate;
    }

    public abstract decimal InterestAmount(int months);
}

public class Mortgage : Account
{ 
    public Mortgage(string customer, CustomerType type, decimal balance, decimal interestRate) : base(customer, type, balance, interestRate)
    {
    }

    public void Deposit(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("Deposit must be less than balance");
        }
        this.Balance -= amount;
    }
    public override decimal InterestAmount(int months)
    {
        if (this.accountType==CustomerType.Company)
        {
            if (months<=12)
            {
                return months * this.interestRate / 2 * this.Balance;
            }
            else
            {
                decimal amount = months * this.interestRate / 2 * this.Balance;
                months -= 12;
                amount += months * this.interestRate * this.Balance;
                return amount;
            }
        }
        else
        {
            if (months<=6)
            {
                return 0;
            }
            else
            {
                months -= 6;
                return months * this.interestRate * this.Balance;
            }
        }
    }
}

public class Loan : Account
{
    public Loan(string customer, CustomerType type, decimal balance, decimal interestRate) : base(customer, type, balance, interestRate)
    {
    }
    
    public void Deposit(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("Deposit must be less than balance");
        }
        this.Balance -= amount;
    }

    public override decimal InterestAmount(int months)
    {
        if (this.accountType==CustomerType.Company)
        {
            months -= 2;
            if (months>0)
            {
                return months * this.interestRate * this.Balance;
            }
            return 0;
        }
        else
        {
            months -= 3;
            if (months > 0)
            {
                return months * this.interestRate * this.Balance;
            }
            return 0;
        }
    }
}