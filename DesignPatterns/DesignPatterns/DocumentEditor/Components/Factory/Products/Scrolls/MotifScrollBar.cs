using DesignPatterns.DocumentEditor.Primitives.Windows;
using System;

namespace DesignPatterns.DocumentEditor.Components.Factory.Products.Scrolls
{
    internal class MotifScrollBar : ScrollBar
    {
        public override void Draw(Window window)
        {
            throw new NotImplementedException();
        }

        public override void ScrollTo(int location)
        {
            throw new NotImplementedException();
        }
    }
}
