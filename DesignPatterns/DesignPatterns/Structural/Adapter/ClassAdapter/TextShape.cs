using DesignPatterns.Primitives.Drawing;

namespace DesignPatterns.Structural.Adapter.ClassAdapter
{
    public class TextShape : TextView, IShape
    {
        public (Point, Point) BoundingBox(int left, int top)
        {
            int x = 0;
            int y = 0;
            int width = 0;
            int height = 0;

            GetOrigin(ref x, ref y);
            GetExtent(ref width, ref height);

            return (new Point(x + width, y + height), new Point(x, y));
        }

        public void CreateManipulator() { }

        public void BoundingBox(ref int left, ref int top) { }

        public override bool IsEmpty => base.IsEmpty;
    }
}
