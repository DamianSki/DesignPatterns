using System;

namespace DesignPatterns.Behavioral.Template
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void RequiredOperation1() => Console.WriteLine($"Overriden abstract operation: {nameof(RequiredOperation1)}");
        protected override void RequiredOperation2() => Console.WriteLine($"Overriden abstract operation: {nameof(RequiredOperation2)}");
    }
}
