using System;

namespace DesignPatterns.Behavioral.Memento;

class EditorMemento
{
    private string _content;

    public EditorMemento(string content)
    {
        _content = content;
    }

    public string Content
    {
        get { return _content; }
    }
}

class Editor
{
    private string _content = string.Empty;
    private EditorMemento _editorMemento;

    public Editor()
    {
        _editorMemento = new(string.Empty);
    }

    public void Type(string words)
    {
        _content = String.Concat(_content, " ", words);
    }

    public string Content
    {
        get { return _content; }
    }

    public void Save()
    {
        _editorMemento = new(_content);
    }

    public void Restore()
    {
        _content = _editorMemento.Content;
    }
}