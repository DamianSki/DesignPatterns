namespace DesignPatterns.Behavioral.Interpreter
{
    public class SubExpression : IExpression
    {
        public SubExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        private readonly IExpression _left;
        private readonly IExpression _right;

        public int Interpret() => _left.Interpret() - _right.Interpret();
    }
}
