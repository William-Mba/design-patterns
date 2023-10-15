using System;

namespace DesignPatterns.Structural.Decorator;

class Computer
{
    public void GetElectrickShock()
    {
        Console.Write("Ouch!");
    }

    public void MakeSound()
    {
        Console.Write("Beep beep!");
    }

    public void ShowLoadingScreen()
    {
        Console.Write("Loading..");
    }

    public void Bam()
    {
        Console.Write("Ready to be used!");
    }

    public void CloseEverything()
    {
        Console.Write("Bup bup bup buzzzzz!");
    }

    public void Sooth()
    {
        Console.Write("Zzzzz");
    }

    public void PullCurrent()
    {
        Console.Write("Haaah!");
    }
}

class ComputerFacade
{
    private readonly Computer _computer;

    public ComputerFacade(Computer computer)
    {
        _computer = computer ??
        throw new ArgumentNullException("computer", "computer cannot be null");
    }

    public void TurnOn()
    {
        _computer.GetElectrickShock();
        _computer.MakeSound();
        _computer.ShowLoadingScreen();
        _computer.Bam();
    }    
    
    public void TurnOff()
    {
        _computer.CloseEverything();
        _computer.PullCurrent();
        _computer.Sooth();
    }
}