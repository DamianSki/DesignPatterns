using System;

namespace DesignPatterns.DocumentEditor.Components.Factory.Products.Buttons
{
    abstract class Button : Glyph
    {
        public override void Insert(Glyph glyph)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Glyph glyph)
        {
            throw new NotImplementedException();
        }

        public void Press()
        {
            throw new NotImplementedException();
        }
    }
}
