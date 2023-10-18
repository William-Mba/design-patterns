using System;

namespace DesignPatterns.Behavioral.Command;

// Receiver
class Bulb
{
    public void TurnOn()
    {
        Console.WriteLine("Bulb has been lit");
    }
    public void TurnOff()
    {
        Console.WriteLine("Darkness!");
    }
}

interface ICommand
{
    void Execute();
    void Undo();
    void Redo();
}

// Command
class TurnOn : ICommand
{
    private Bulb _bulb;

    public TurnOn(Bulb bulb)
    {
        _bulb = bulb ?? throw new ArgumentNullException("bulb", "bulb cannot be null");
    }

    public void Execute()
    {
        _bulb.TurnOn();
    }

    public void Redo()
    {
        Execute();
    }

    public void Undo()
    {
        _bulb.TurnOff();
    }
}

class TurnOff : ICommand
{
    private Bulb _bulb;

    public TurnOff(Bulb bulb)
    {
        _bulb = bulb ?? throw new ArgumentNullException("bulb", "bulb cannot be null");
    }

    public void Execute()
    {
        _bulb.TurnOff();
    }

    public void Redo()
    {
        Execute();
    }

    public void Undo()
    {
        _bulb.TurnOn();
    }
}

// Invoker
class RemoteControl
{
    public void Submit(ICommand command)
    {
        command.Execute();
    }
}