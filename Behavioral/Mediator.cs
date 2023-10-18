using System;

namespace DesignPatterns.Behavioral.Mediator;

interface IChatRoomMediator
{
    void ShowMessage(User user, string message);
}

// Mediator
class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        Console.WriteLine($"{DateTime.Now.ToString("MMMM dd, H:mm")} [{user.GetName()}]: {message}");
    }
}

class User
{
    private string _name;
    private IChatRoomMediator _chatRoom;

    public User(string name, IChatRoomMediator chatRoom)
    {
        _name = name;
        _chatRoom = chatRoom;
    }

    public string GetName()
    {
        return _name;
    }

    public void Send(string message)
    {
        _chatRoom.ShowMessage(this, message);
    }
}