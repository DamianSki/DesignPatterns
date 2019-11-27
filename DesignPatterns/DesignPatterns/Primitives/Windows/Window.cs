using DesignPatterns.DocumentEditor.Primitives.Windows.Systems;

namespace DesignPatterns.DocumentEditor.Primitives.Windows
{
    public abstract class Window
    {
        public Window(WindowImp window)
        {
            _window = window;
        }

        protected WindowImp _window;
        public abstract void Redraw();
        public abstract void Iconify();
        public abstract void Deiconify();
        public abstract void Lower();
        public abstract void Raise();
        public abstract void DrawLine();
        public abstract void Open(); 
        public abstract void Close();

        protected virtual WindowImp GetWindowImp() {
            return null; //creates specifi window imp
        }
    }
}
