namespace DesignPatterns.Structural.Adapter
{
    public class TextShape : IShape
    {
        private readonly TextView _textView;

        public TextShape(TextView textView)
        {
            _textView = textView;
        }

        public void BoundingBox(ref int left, ref int top)
        {
            int x = 0;
            int y = 0;
            int width = 0;
            int height = 0;

            _textView.GetOrigin(ref x, ref y);
            _textView.GetExtent(ref width, ref height);

            left = x + y;
        }

        public void CreateManipulator()
        {

        }
    }
}
