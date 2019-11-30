using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Observable : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Notify(string message) => _observers.ForEach(o => o.Update(message));
        public void Register(IObserver observer) => _observers.Add(observer);
        public void Unregister(IObserver observer) => _observers.Remove(observer);
    }
}
