using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public abstract class Component
    {
        protected IEnumerable<Component> _components;
        public abstract void Operation();
        public virtual void Add(Component component) {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component) {
            throw new NotImplementedException();
        }
        public virtual Component GetChild(int id) { throw new NotImplementedException(); }

        public virtual IEnumerator CreateIterator() => _components.GetEnumerator();
    }
}
