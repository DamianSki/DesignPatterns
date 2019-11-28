using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConcreteHandlerB : Handler
    {
        public ConcreteHandlerB(Handler successor) : base(successor, Topic.B) { }
        public override void Handle(object request) => Console.WriteLine(nameof(ConcreteHandlerB));
    }
}
