namespace DesignPatterns.Structural.Bridge;

interface IWebPage
{
    string GetContent();
}

class About : IWebPage
{
    protected ITheme Theme;

    public About(ITheme theme)
    {
        Theme = theme;
    }

    public string GetContent()
    {
        return $"About page in {Theme.GetColor()}";
    }
}

class Careers : IWebPage
{
    protected ITheme Theme;

    public Careers(ITheme theme)
    {
        Theme = theme;
    }

    public string GetContent()
    {
        return $"Careers page in {Theme.GetColor()}";
    }
}

interface ITheme
{
    string GetColor();
}

class DarkTheme : ITheme
{
    public string GetColor()
    {
        return "Dark Black";
    }
}

class LightTheme : ITheme
{
    public string GetColor()
    {
        return "Off White";
    }
}

class AquaTheme : ITheme
{
    public string GetColor()
    {
        return "Light Blue";
    }
}