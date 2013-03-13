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