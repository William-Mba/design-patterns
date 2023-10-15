using System;

namespace DesignPatterns.Structural.Decorator;

interface ICoffee
{
    int GetCost();
    string GetDescription();
}

class SimpleCoffee : ICoffee
{
    public int GetCost()
    {
        return 5;
    }

    public string GetDescription()
    {
        return "Simple Coffee";
    }
}

class MilkCoffee : ICoffee
{
    private readonly ICoffee _coffee;
    public MilkCoffee(ICoffee coffee)
    {
        _coffee = coffee ??
        throw new ArgumentNullException("coffee", "coffee should not be null");
    }

    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", milk");
    }
}

class WhipCoffee : ICoffee
{
    private readonly ICoffee _coffee;
    public WhipCoffee(ICoffee coffee)
    {
        _coffee = coffee ??
        throw new ArgumentNullException("coffee", "coffee should not be null");
    }

    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", whip");
    }
}

class VanillaCoffee : ICoffee
{
    private readonly ICoffee _coffee;
    public VanillaCoffee(ICoffee coffee)
    {
        _coffee = coffee ??
        throw new ArgumentNullException("coffee", "coffee should not be null");
    }

    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", vanilla");
    }
}