using System;

namespace DesignPatterns.DocumentEditor.Components.Factory.Products.Menus
{
    abstract class Menu : Glyph
    {
        public abstract void Popup();

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
