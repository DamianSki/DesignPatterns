namespace DesignPatterns.DocumentEditor.Iterators
{
    interface IIterator<T>
    {
        void First();
        void Next();
        bool IsDone();
        T CurrentITem();
    }
}
