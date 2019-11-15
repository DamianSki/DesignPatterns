using DesignPatterns.DocumentEditor.Primitives.Windows.Systems;

namespace DesignPatterns.DocumentEditor.Primitives.Windows
{
    abstract class Window
    {
        protected WindowImp _window;

        public abstract void Redraw();
        public abstract void Iconify();
        public abstract void Lower();
        public abstract void DrawLine();
    }
}
