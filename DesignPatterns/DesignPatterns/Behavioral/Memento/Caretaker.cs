using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        public Caretaker(Originator originator) => _originator = originator;
        
        Stack<IMemento> _mementos = new Stack<IMemento>();
        private readonly Originator _originator;

        public void Do() => _mementos.Push(_originator.Save());
        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var memento = _mementos.Pop();
            _originator.Restore(memento);
        }
    }
}
