using System;


namespace StrategyPattern;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }

}
