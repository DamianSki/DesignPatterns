using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteComponentA : Component
    {
        public ConcreteComponentA(IMediator mediator) : base(mediator)
        {
        }
        public void ActionA()
        {
            Console.WriteLine(nameof(ActionA));
            Mediator.Notify(this, Actions.C);
        }
        public void ActionB()
        {
            Console.WriteLine(nameof(ActionB));
            Mediator.Notify(this, Actions.D);
        }
    }
}
