using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteComponentB : Component
    {
        public ConcreteComponentB(IMediator mediator) : base(mediator)
        {
        }

        public void ActionC() => Console.WriteLine(nameof(ActionC));

        public void ActionD() => Console.WriteLine(nameof(ActionD));
    }
}
