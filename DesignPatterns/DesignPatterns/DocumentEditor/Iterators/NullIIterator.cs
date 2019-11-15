using System;

namespace DesignPatterns.DocumentEditor.Iterators
{
    class NullIterator : IIterator<object>
    {
        public void First()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        object IIterator<object>.CurrentITem()
        {
            throw new NotImplementedException();
        }
    }
}
