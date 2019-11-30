using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Memento : IMemento
    {
        public Memento(string state)
        {
            State = state;
            Date = DateTime.Now;
        }        
        public string State { get; private set; }
        public DateTime Date { get; private set; }
    }
}
