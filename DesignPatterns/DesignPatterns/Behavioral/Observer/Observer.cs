using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class Observer : IObserver
    {       
        public Observer(string name) => _name = name;
        private string _name;
        public void Update(string message) => Console.WriteLine($"Observer: {_name} received: {message}");
    }
}
