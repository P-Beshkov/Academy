using System;

class Deposit : Account
{
    
    public Deposit(string customer, CustomerType type, decimal balance, decimal interestRate) : base(customer, type, balance, interestRate)
    {
    }

    public void Add(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdrow(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("Not enough balance");
        }
        this.Balance -= amount;
    }


    public override decimal InterestAmount(int months)
    {
        if (this.Balance<1000)
        {
            return 0;
        }
        else
        {
            return months * this.Balance * this.interestRate;
        }
    }
}