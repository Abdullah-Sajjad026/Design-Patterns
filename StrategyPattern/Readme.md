# Strategy Pattern

<!-- below is a Table with some categorization like family or algorithm, key ideas, defination, OOP concepts used, ...etc -->

| Category         | Value                                                                                                                                                                                |
| ---------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Family**       | Behavioral                                                                                                                                                                           |
| **Key Ideas**    | Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.                         |
| **Definition**   | The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it. |
| **OOP Concepts** | Encapsulation, Inheritance, Polymorphism                                                                                                                                             |

## What is Strategy Pattern?

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## What does family of algorithms and encapsulate each one mean?

A family of algorithms is a set of algorithms that do the same job but in different ways. For example, sorting algorithms like Bubble Sort, Quick Sort, Merge Sort, etc. are a family of algorithms that sort a list of elements but in different ways. Similarly in the SimUDuck example, the Duck family has different flying behaviors like FlyWithWings, FlyNoWay, FlyRocketPowered, etc.

Encapsulating each algorithm means that each algorithm is implemented in a separate class. This way, the algorithm can be changed without affecting the client code that uses the algorithm. For example, in the SimUDuck example, the flying behavior is encapsulated in separate classes like FlyWithWings, FlyNoWay, FlyRocketPowered, etc and can be changed independently of the Duck class.

## What does making algorithms interchangeable mean?

Making algorithms interchangeable means that the client code can switch between different algorithms at runtime. For example, in the SimUDuck example, the flying behavior of a Duck can be changed at runtime by setting the flying behavior to FlyWithWings, FlyNoWay, FlyRocketPowered, etc.

This is achieved by defining a common interface for all algorithms and implementing different algorithms as concrete classes that implement this interface. The client code can then use this interface to interact with different algorithms without knowing their concrete classes.

## How does Strategy Pattern work?

The Strategy Pattern works by defining a common interface for all algorithms and implementing different algorithms as concrete classes that implement this interface. The client code interacts with these algorithms through the common interface, which allows it to switch between different algorithms at runtime.

Here's how the Strategy Pattern works in the SimUDuck example:

1. Define a common interface for all flying behaviors:

```csharp
public interface IFlyBehavior
{
    void Fly();
}
```

2. Implement different flying behaviors as concrete classes that implement the `IFlyBehavior` interface:

```csharp
public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly!");
    }
}

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
```

3. In the `Duck` class, add a property of type `IFlyBehavior` to hold the flying behavior and a method to set the flying behavior:

```csharp
public abstract class Duck
{
    protected IFlyBehavior flyBehavior;

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }
}
```

4. Create different types of Ducks and set their flying behavior at runtime:

```csharp
Duck mallard = new MallardDuck();
mallard.SetFlyBehavior(new FlyWithWings());
mallard.PerformFly(); // Output: I'm flying with wings!

Duck rubberDuck = new RubberDuck();
rubberDuck.SetFlyBehavior(new FlyNoWay());
rubberDuck.PerformFly(); // Output: I can't fly!

Duck decoyDuck = new DecoyDuck();
decoyDuck.SetFlyBehavior(new FlyRocketPowered());
decoyDuck.PerformFly(); // Output: I'm flying with a rocket!
```

## What are the benefits of using Strategy Pattern?

The Strategy Pattern offers the following benefits:

1. **Flexibility**: It allows the client code to switch between different algorithms at runtime without changing its structure.

2. **Encapsulation**: It encapsulates each algorithm in a separate class, making it easier to maintain and extend the code.

3. **Reusability**: It promotes code reuse by allowing different clients to reuse the same algorithms.

4. **Testability**: It makes it easier to test the algorithms independently of the client code.

5. **Simplicity**: It simplifies the client code by removing conditional statements and moving the algorithm selection logic to separate classes.

## When to use Strategy Pattern?

You should use the Strategy Pattern when:

1. You have a family of algorithms that do the same job but in different ways.

2. You want to encapsulate each algorithm in a separate class.

3. You want to make the algorithms interchangeable at runtime.

4. You want to avoid conditional statements in the client code.

5. You want to reuse the algorithms in different contexts.

## Summary

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows the client code to switch between different algorithms at runtime without changing its structure. The Strategy Pattern promotes flexibility, encapsulation, reusability, testability, and simplicity in the code. You should use the Strategy Pattern when you have a family of algorithms that do the same job but in different ways and you want to make them interchangeable at runtime.
