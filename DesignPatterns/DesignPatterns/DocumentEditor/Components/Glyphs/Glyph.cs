using DesignPatterns.DocumentEditor.Commands;
using DesignPatterns.DocumentEditor.Iterators;
using DesignPatterns.DocumentEditor.Primitives;
using DesignPatterns.DocumentEditor.Primitives.Windows;
using DesignPatterns.Primitives.Drawing;

namespace DesignPatterns.DocumentEditor.Components
{
    abstract class Glyph
    {
        protected Command _command;

        public abstract void Draw(Window window);
        public virtual void Bounds(Rectangle rectangle) { }
        public virtual bool Intersects(Point point) { return true; }
        public abstract void Insert(Glyph glyph);
        public abstract void Remove(Glyph glyph);

        public virtual IIterator<object> CreateIterator()
        {
            return new NullIterator();
        }
    }
}
