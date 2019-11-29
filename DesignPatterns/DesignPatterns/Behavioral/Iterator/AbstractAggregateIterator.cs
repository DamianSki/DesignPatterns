using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    public abstract class AbstractAggregateIterator : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

}
