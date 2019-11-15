using DesignPatterns.DocumentEditor.Components.Commands;
using DesignPatterns.DocumentEditor.Primitives;
using DesignPatterns.DocumentEditor.Primitives.Windows;

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
    }
}
