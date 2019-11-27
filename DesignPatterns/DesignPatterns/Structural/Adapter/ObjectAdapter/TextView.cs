namespace DesignPatterns.Structural.Adapter
{
    public class TextView
    {
        public TextView() { }

        public void GetOrigin(ref int x, ref int y)
        {
        }

        public void GetExtent(ref int width, ref int height) { }
        public virtual bool IsEmpty => true;
    }
}
