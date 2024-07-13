using System;

namespace StrategyPattern;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {
    }

    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.QuackNow();
    }

    public void Swin()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}
