using System;

namespace DesignPatterns.Behavioral.TemplateMethod;

abstract class Builder
{
    // Template method
    public void Build()
    {
        Test();
        Lint();
        Assemble();
        Deploy();
    }

    protected abstract void Test();
    protected abstract void Lint();
    protected abstract void Assemble();
    protected abstract void Deploy();
}

class AndroidBuilder : Builder
{
    protected override void Assemble()
    {
        Console.WriteLine("Assembling the android build");
    }

    protected override void Deploy()
    {
        Console.WriteLine("Deploying android build to server");
    }

    protected override void Lint()
    {
        Console.WriteLine("Linting the android code");
    }

    protected override void Test()
    {
        Console.WriteLine("Running android tests");
    }
}

class IosBuilder : Builder
{
    protected override void Assemble()
    {
        Console.WriteLine("Assembling the ios build");
    }

    protected override void Deploy()
    {
        Console.WriteLine("Deploying ios build to server");
    }

    protected override void Lint()
    {
        Console.WriteLine("Linting the ios code");
    }

    protected override void Test()
    {
        Console.WriteLine("Running ios tests");
    }
}