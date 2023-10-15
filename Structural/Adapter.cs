namespace DesignPatterns.Structural.Adapter;

interface ILion
{
    void Roar();
}

class AfricanLion : ILion
{
    public void Roar()
    {
    }
}

class AsiaLion : ILion
{
    public void Roar()
    {
    }
}

class Hunter
{
    public void Hunt(ILion lion)
    {

    }
}

class WildDog
{
    public void Bark()
    {

    }
}

// Adapter around wild dog to make it compatible with our game
class WildDogAdapter : ILion
{
    private WildDog _dog;

    public WildDogAdapter(WildDog dog)
    {
        _dog = dog;
    }

    public void Roar()
    {
        _dog.Bark();
    }
}