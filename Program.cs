using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;

public class Program
{
    private static void Main(string[] args)
    {
        #region Creational Design Patterns
        // Simple factory pattern
        var door = DoorFactory.MakeDoor(80, 30);
        Console.WriteLine($"Height of Door: {door.GetHeight()}");
        Console.WriteLine($"Width of Door: {door.GetWidth()}");

        // Factory Method pattern
        var devManager = new DeveloppementManager();
        devManager.TakeInterview();

        var marketingManager = new MarketingManager();
        marketingManager.TakeInterview();

        // Abstract Factory pattern
        var woodenDoorFactory = new WoodenDoorFactory();
        var woodenDoor = woodenDoorFactory.MakeDoor();
        var woodenDoorFittingExpert = woodenDoorFactory.MakeFittingExpert();

        woodenDoor.GetDescription();
        woodenDoorFittingExpert.GetDescription();

        var ironDoorFactory = new IronDoorFactory();
        var ironDoor = ironDoorFactory.MakeDoor();
        var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

        ironDoor.GetDescription();
        ironDoorFittingExpert.GetDescription();

        // Builder pattern
        var burger = new BurgerBuilder(5)
                        .AddCheese()
                        .AddPepperoni()
                        .AddLettuce()
                        .AddTomato()
                        .Build();
        Console.WriteLine(burger.GetDescription());

        // Prototype pattern
        var original = new Sheep("Jolly", "Mountain Sheep");
        Console.WriteLine(original.Name);
        Console.WriteLine(original.Category);

        var cloned = original.Clone();
        cloned.Name = "Dolly";
        Console.WriteLine(cloned.Name);
        Console.WriteLine(cloned.Category);
        Console.WriteLine(original.Name);

        // Singleton pattern
        var a = President.GetInstance();
        var b = President.GetInstance();
        
        Console.WriteLine(a == b);
        #endregion

    }
}