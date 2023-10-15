using System.Text;

namespace DesignPatterns.Creational.Builder;

class Burger
{
    private int size;
    private bool cheese;
    private bool pepperoni;
    private bool lettuce;
    private bool tomato;

    public Burger(BurgerBuilder builder)
    {
        this.size = builder.Size;
        this.cheese = builder.Cheese;
        this.pepperoni = builder.Pepperoni;
        this.lettuce = builder.Lettuce;
        this.tomato = builder.Tomato;
    }

    public string GetDescription()
    {
        var sb = new StringBuilder();
        sb.Append($"This is {this.size} inch Burger. ");
        return sb.ToString();
    }
}

class BurgerBuilder
{
    public int Size;
    public bool Cheese;
    public bool Pepperoni;
    public bool Lettuce;
    public bool Tomato;

    public BurgerBuilder(int size)
    {
        this.Size = size;
    }

    public BurgerBuilder AddCheese()
    {
        this.Cheese = true;
        return this;
    }

    public BurgerBuilder AddPepperoni()
    {
        this.Pepperoni = true;
        return this;
    }

    public BurgerBuilder AddLettuce()
    {
        this.Lettuce = true;
        return this;
    }

    public BurgerBuilder AddTomato()
    {
        this.Tomato = true;
        return this;
    }

    public Burger Build()
    {
        return new Burger(this);
    }
}