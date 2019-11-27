namespace DesignPatterns.Structural.Adapter
{
    public interface IShape
    {
        public abstract void BoundingBox(ref int left, ref int top);
        public abstract void CreateManipulator();
    }
}
