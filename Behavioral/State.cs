using System;

namespace DesignPatterns.Behavioral.State;

// First of all we have our state interface and some state implementations
interface IWritingState
{
    void Write(string words);
}

class UpperCase : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words.ToUpper());
    }
}

class LowerCase : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words.ToLower());
    }
}

class DefaultText : IWritingState
{
    public void Write(string words)
    {
        Console.WriteLine(words);
    }
}

// Then we have our editor
class TextEditor
{
    private IWritingState _writingState;

    public TextEditor()
    {
        _writingState = new DefaultText();
    }

    public void SetState(IWritingState state)
    {
        _writingState = state;
    }

    public void Type(string words)
    {
        _writingState.Write(words);
    }
}