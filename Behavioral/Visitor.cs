using System;

namespace DesignPatterns.Behavioral.Visitor;

// Visitee
interface IAnimal
{
    void Accept(IAnimalOperation operation);
}

// Visitor
interface IAnimalOperation
{
    void VisitMonkey(Monkey monkey);
    void VisitLion(Lion lion);
    void VisitDolphin(Dolphin dolphin);
}

class Dolphin : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Tuut titu tuutt!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitDolphin(this);
    }
}

class Lion : IAnimal
{
    public void Roar()
    {
        Console.WriteLine("Roar!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitLion(this);
    }
}

class Monkey : IAnimal
{
    public void Shout()
    {
        Console.WriteLine("Ooooh o aa aa!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitMonkey(this);
    }
}

class Speak : IAnimalOperation
{
    public void VisitDolphin(Dolphin dolphin)
    {
        dolphin.Speak();
    }

    public void VisitLion(Lion lion)
    {
        lion.Roar();
    }

    public void VisitMonkey(Monkey monkey)
    {
        monkey.Shout();
    }
}

class Jump : IAnimalOperation
{
    public void VisitDolphin(Dolphin dolphin)
    {
        Console.WriteLine("Walked on water a little and disappeared!");
    }

    public void VisitLion(Lion lion)
    {
        Console.WriteLine("Jumped 7 feet! Back on the ground!");
    }

    public void VisitMonkey(Monkey monkey)
    {
        Console.WriteLine("Jumped 20 feet high! on to the three!");
    }
}