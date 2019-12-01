using System;

namespace DesignPatterns.Behavioral.Template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            BaseOperation2();
        }
        protected void BaseOperation1() => Console.WriteLine($"This opration: {nameof(BaseOperation1)} cannot be overriden");
        protected void BaseOperation2() => Console.WriteLine($"This opration: {nameof(BaseOperation2)} cannot be overriden");
        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();
        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
