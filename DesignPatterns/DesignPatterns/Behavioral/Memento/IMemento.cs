using System;

namespace DesignPatterns.Behavioral.Memento
{
    public interface IMemento
    {
        public string State { get; }
        public DateTime Date { get; }
    }
}
