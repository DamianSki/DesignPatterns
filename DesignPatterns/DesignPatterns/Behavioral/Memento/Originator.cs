using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        public Originator(string state) => _state = state;
        private string _state;
        public void Action()
        {
            var random = new Random();
            _state = random.Next(0, 100).ToString();
        }

        public IMemento Save() => new Memento(_state);

        public void Restore(IMemento memento) 
        {
            if (memento is IMemento)
                _state = memento.State;

            throw new ArgumentException();
        }
    }
}
