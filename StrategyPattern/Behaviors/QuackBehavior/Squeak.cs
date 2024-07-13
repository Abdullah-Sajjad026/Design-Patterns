namespace StrategyPattern;

public class Squeak : IQuackBehavior
{
    public void QuackNow()
    {
        Console.WriteLine("Squeak");
    }
}