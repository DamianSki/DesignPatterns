namespace DesignPatterns.DocumentEditor.Components.Factory
{
    abstract class GUIFactory
    {
        public abstract Glyph CreateScrollBar();
        public abstract Glyph CreateButton();
        public abstract Glyph CreateMenu();
    }
}
