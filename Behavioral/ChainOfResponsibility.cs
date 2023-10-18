using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility;

abstract class Account
{
    private Account _successor;
    protected decimal Balance;

    public void SetNext(Account account)
    {
        _successor = account;
    }

    public void Pay(decimal amountToPay)
    {
        if (CanPay(amountToPay))
        {
            Console.WriteLine($"Paid {amountToPay:c} using {this.GetType().Name}.");
        }
        else if (_successor != null)
        {
            Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
            _successor.Pay(amountToPay);
        }
        else
        {
            throw new Exception("None of the accounts have enough balance");
        }
    }

    private bool CanPay(decimal amount)
    {
        return Balance >= amount;
    }
}

class Bank : Account
{
    public Bank(decimal balance)
    {
        this.Balance = balance;
    }
}

class PayPal : Account
{
    public PayPal(decimal balance)
    {
        this.Balance = balance;
    }
}

class Bitcoin : Account
{
    public Bitcoin(decimal balance)
    {
        this.Balance = balance;
    }
}