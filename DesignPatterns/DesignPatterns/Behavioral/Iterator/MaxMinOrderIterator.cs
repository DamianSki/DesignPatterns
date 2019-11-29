using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Iterator
{
    public class MaxMinOrderIterator : Iterator
    {
        public MaxMinOrderIterator(NumbersCollection numbersCollection) => _numbersCollection = numbersCollection.CopyItems().OrderByDescending(x => x).ToList();

        private IList<int> _numbersCollection;
        private int _position = 0;

        public override object Current() => _numbersCollection[_position];

        public override int Key() => _position;

        public override bool MoveNext()
        {
            if (_position < _numbersCollection.Count)
            {
                _position++;
                return true;
            }

            return false;
        }

        public override void Reset() => _position = 0;
    }

}
