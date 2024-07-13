
using StrategyPattern;

namespace StrategyPattern;

public class Quack : IQuackBehavior
{
    public void QuackNow()
    {
        Console.WriteLine("Quack");
    }
}