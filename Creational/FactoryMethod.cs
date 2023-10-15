namespace DesignPatterns.Creational.FactoryMethod;

interface IInterviewer
{
    void AskQuestions();
}

class Developper : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine($"Asking about design patterns");
    }
}

class CommunityExecutive : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine($"Asking about comunity building");
    }
}

abstract class HiringManager
{
    // Factory method
    abstract protected IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = this.MakeInterviewer();
        interviewer.AskQuestions();
    }
}

class DeveloppementManager: HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developper();
    }
}

class MarketingManager: HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}