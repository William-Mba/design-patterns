using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

public class Program
{
    private static void Main(string[] args)
    {
        #region Creational Design Patterns
        // // Simple factory pattern
        // var door = DoorFactory.MakeDoor(80, 30);
        // Console.WriteLine($"Height of Door: {door.GetHeight()}");
        // Console.WriteLine($"Width of Door: {door.GetWidth()}");

        // // Factory Method pattern
        // var devManager = new DeveloppementManager();
        // devManager.TakeInterview();

        // var marketingManager = new MarketingManager();
        // marketingManager.TakeInterview();

        // // Abstract Factory pattern
        // var woodenDoorFactory = new WoodenDoorFactory();
        // var woodenDoor = woodenDoorFactory.MakeDoor();
        // var woodenDoorFittingExpert = woodenDoorFactory.MakeFittingExpert();

        // woodenDoor.GetDescription();
        // woodenDoorFittingExpert.GetDescription();

        // var ironDoorFactory = new IronDoorFactory();
        // var ironDoor = ironDoorFactory.MakeDoor();
        // var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

        // ironDoor.GetDescription();
        // ironDoorFittingExpert.GetDescription();

        // // Builder pattern
        // var burger = new BurgerBuilder(5)
        //                 .AddCheese()
        //                 .AddPepperoni()
        //                 .AddLettuce()
        //                 .AddTomato()
        //                 .Build();
        // Console.WriteLine(burger.GetDescription());

        // // Prototype pattern
        // var original = new Sheep("Jolly", "Mountain Sheep");
        // Console.WriteLine(original.Name);
        // Console.WriteLine(original.Category);

        // var cloned = original.Clone();
        // cloned.Name = "Dolly";
        // Console.WriteLine(cloned.Name);
        // Console.WriteLine(cloned.Category);
        // Console.WriteLine(original.Name);

        // // Singleton pattern
        // var a = President.GetInstance();
        // var b = President.GetInstance();

        // Console.WriteLine(a == b);
        #endregion

        #region Structural Design Patterns
        // // Adapter pattern
        // var wildDog = new WildDog();
        // var wildDogAdapter = new WildDogAdapter(wildDog);

        // var hunter = new Hunter();
        // hunter.Hunt(wildDogAdapter);

        // // Bridge pattern
        // var darkTheme = new DarkTheme();
        // var lightTheme = new LightTheme();

        // var about = new About(darkTheme);
        // var careers = new Careers(lightTheme);

        // Console.WriteLine(about.GetContent());
        // Console.WriteLine(careers.GetContent());

        // // Composite pattern
        // var developer = new DesignPatterns.Structural.Composite.Developer("John", 5000);
        // var designer = new Designer("Arya", 5000);

        // var organisation = new Organization();
        // organisation.AddEmployee(developer);
        // organisation.AddEmployee(designer);

        // Console.WriteLine($"Net salary of employees in Organization is {organisation.GetNetSalaries():c}");

        // // Decorator pattern
        // var myCoffee = new SimpleCoffee();
        // Console.WriteLine($"{myCoffee.GetCost():c}");
        // Console.WriteLine(myCoffee.GetDescription());

        // var milkCoffee = new MilkCoffee(myCoffee);
        // Console.WriteLine($"{milkCoffee.GetCost():c}");
        // Console.WriteLine(milkCoffee.GetDescription());

        // var whipCoffee = new WhipCoffee(myCoffee);
        // Console.WriteLine($"{whipCoffee.GetCost():c}");
        // Console.WriteLine(whipCoffee.GetDescription());

        // var vanillaCoffee = new VanillaCoffee(myCoffee);
        // Console.WriteLine($"{vanillaCoffee.GetCost():c}");
        // Console.WriteLine(vanillaCoffee.GetDescription());

        // // Facade pattern
        // var computer = new ComputerFacade(new Computer());
        // computer.TurnOn();
        // Console.WriteLine();
        // computer.TurnOff();
        // Console.ReadLine();

        // // Flyweight pattern
        // var teaMaker = new TeaMaker();
        // var teaShop = new TeaShop(teaMaker);

        // teaShop.TakeOrder("less sugar", 1);
        // teaShop.TakeOrder("more milk", 2);
        // teaShop.TakeOrder("without sugar", 5);

        // teaShop.Serve();

        // Proxy pattern
        var door = new SecuredDoor(new LabDoor());
        door.Open("invalid");

        door.Open("$ecr@t");
        door.Close();
        #endregion
    }
}