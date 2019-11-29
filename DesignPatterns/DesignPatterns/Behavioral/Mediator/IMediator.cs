namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, Actions action);
    }
}
