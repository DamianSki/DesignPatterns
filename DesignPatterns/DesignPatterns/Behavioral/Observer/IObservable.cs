namespace DesignPatterns.Behavioral.Observer
{
    public interface IObservable 
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify(string message);
    }
}
