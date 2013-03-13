using System;

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
        if (this.accountType == CustomerType.Company)
        {
            months -= 2;
            if (months > 0)
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