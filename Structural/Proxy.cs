using System;

namespace DesignPatterns.Structural.Proxy;

interface IDoor
{
    void Open();
    void Close();
}
interface ISecureDoor
{
    void Open(string password);
    void Close();
}
class LabDoor : IDoor
{
    public void Close()
    {
        Console.WriteLine("Closing lab door");
    }

    public void Open()
    {
        Console.WriteLine("Opening lab door");
    }
}

class SecuredDoor : ISecureDoor
{
    private IDoor _door;

    public SecuredDoor(IDoor door)
    {
        _door = door ?? throw new ArgumentNullException("door", "door cannot be nul");
    }

    private bool Authenticate(string password)
    {
        return password == "$ecr@t";
    }

    public void Open(string password)
    {
        if (Authenticate(password))
        {
            _door.Open();
        }
        else
        {
            Console.WriteLine("Big no! It ain't possible.");
        }
    }

    public void Close()
    {
        _door.Close();
    }
}