using System;

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
        if (this.accountType == CustomerType.Company)
        {
            if (months <= 12)
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
            if (months <= 6)
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