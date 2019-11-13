using System;

namespace DesignPatterns.DocumentEditor.Components.Factory.Products.Scrolls
{
    abstract class ScrollBar : Glyph
    {
        public abstract void ScrollTo(int location);

        public override void Insert(Glyph glyph)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Glyph glyph)
        {
            throw new NotImplementedException();
        }
    }
}
