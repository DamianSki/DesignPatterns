using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();

        public abstract int Key();
    }

}
