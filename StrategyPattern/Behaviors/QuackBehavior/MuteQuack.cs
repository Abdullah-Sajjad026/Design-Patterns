using StrategyPattern;

namespace StrategyPattern;

public class MuteQuack : IQuackBehavior
{
    public void QuackNow()
    {
        Console.WriteLine("<< Silence >>");
    }
}