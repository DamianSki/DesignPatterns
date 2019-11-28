using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public ConcreteHandlerA(Handler successor) : base(successor, Topic.A) { }
        public override void Handle(object request) => Console.WriteLine(nameof(ConcreteHandlerA));
    }
}
