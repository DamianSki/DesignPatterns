namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Component
    {
        public Component(IMediator mediator) => Mediator = mediator;

        public readonly IMediator Mediator;
    }
}
