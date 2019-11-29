using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class NumbersCollection : AbstractAggregateIterator
    {
        private IList<int> _numbers = new List<int>();
        public override IEnumerator GetEnumerator() => new MaxMinOrderIterator(this);
        public IList<int> CopyItems() => new List<int>(_numbers);
        public void Add(int number) => _numbers.Add(number);
    }

}
