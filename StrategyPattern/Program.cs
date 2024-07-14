using StrategyPattern;

Console.WriteLine("Hello, World!");
Duck mallardDuck = new MallardDuck();
mallardDuck.PerformFly();
mallardDuck.PerformQuack();

Duck modelDuck = new ModelDuck();
modelDuck.PerformFly();
modelDuck.SetFlyBehavior(new FlyRocketPowered());
modelDuck.PerformFly();