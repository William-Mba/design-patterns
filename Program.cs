using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
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
        // var door = new SecuredDoor(new LabDoor());
        // door.Open("invalid");

        // door.Open("$ecr@t");
        // door.Close();
        #endregion

        #region Behavioral Design Patterns
        // // Chain Of Responsability pattern
        // var bank = new Bank(100);
        // var paypal = new PayPal(200);
        // var bitcoin = new Bitcoin(300);

        // bank.SetNext(paypal);
        // paypal.SetNext(bitcoin);

        // bank.Pay(260);

        // // Command pattern
        // var bulb = new Bulb();

        // var turnOn = new TurnOn(bulb);
        // var turnOff = new TurnOff(bulb);

        // var remote = new RemoteControl();
        // remote.Submit(turnOn);
        // remote.Submit(turnOff);

        // Console.ReadLine();

        // // Iterator pattern
        // var stations = new StationList();
        // var station1 = new RadioStation(89);
        // stations.Add(station1);

        // var station2 = new RadioStation(101);
        // stations.Add(station2);

        // var station3 = new RadioStation(102);
        // stations.Add(station3);

        // foreach (var x in stations)
        // {
        //     Console.Write(x.GetFrequency());
        // }

        // var q = stations.Where(x => x.GetFrequency() == 89).FirstOrDefault();
        // Console.WriteLine(q.GetFrequency());
        // Console.ReadLine();

        // // Mediator pattern
        // var mediator = new ChatRoom();

        // var john = new User("John", mediator);
        // var jane = new User("Jane", mediator);

        // john.Send("Hi there!");
        // jane.Send("Hey!");

        // // Memento pattern
        // var editor = new Editor();

        // // Type some stuff
        // editor.Type("This is the first sentence.");
        // editor.Type("This is the second.");

        // // Save the state to restore to: This is the first sentence. This is the second.
        // editor.Save();

        // // Type some more
        // editor.Type("This is third.");

        // // Output the content
        // Console.WriteLine(editor.Content); // This is the first sentence. This is the second. Thsi is third.

        // // Restoring to last saved state
        // editor.Restore();
        // Console.WriteLine(editor.Content);

        // // Observer pattern
        // // Create subscribers
        // var johnDoe = new JobSeeker("John Doe");
        // var janeDoe = new JobSeeker("Jane Doe");

        // // Create publisher and attach subscriber
        // var jobPostings = new JobPostings();
        // jobPostings.Subscribe(johnDoe);
        // jobPostings.Subscribe(janeDoe);

        // // Add a new job and see if subscriber get notified
        // jobPostings.AddJob(new JobPost("Software Engineer"));

        // // Visitor pattern
        // var monkey = new Monkey();
        // var lion = new Lion();
        // var dolphin = new Dolphin();

        // var speak = new Speak();
        // var jump = new Jump();

        // monkey.Accept(speak);
        // monkey.Accept(jump);

        // dolphin.Accept(speak);
        // dolphin.Accept(jump);

        // lion.Accept(speak);
        // lion.Accept(jump);

        // // Strategy pattern
        // var unSortedList = new List<int> { 1, 10, 2, 16, 19 };

        // var sorter = new Sorter(new BubbleSortStrategy());
        // sorter.Sort(unSortedList);

        // sorter = new Sorter(new QuickSortStrategy());
        // sorter.Sort(unSortedList);

        // // State pattern
        // var editor = new TextEditor();
        // editor.Type("First line");

        // editor.SetState(new UpperCase());
        // editor.Type("Second Line");
        // editor.Type("Third Line");

        // editor.SetState(new LowerCase());
        // editor.Type("Fourth Line");
        // editor.Type("Fifthe Line");

        // Template Method pattern
        var androidBuilder = new AndroidBuilder();
        androidBuilder.Build();

        var iosBuilder = new IosBuilder();
        iosBuilder.Build();
        #endregion
    }
}
