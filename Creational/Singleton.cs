namespace DesignPatterns.Creational.Singleton;

/* To makes a singleton, make the construction private, 
disable cloning, disable extension and create a static variable to house the instance */
public class President
{
    static President instance;

    // private constructor
    private President()
    {
    }

    // Public constructor
    public static President GetInstance()
    {
        instance ??= new President();
        return instance;
    }
}