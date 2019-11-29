namespace DesignPatterns.Behavioral.Interpreter
{
    public class AddExpression : IExpression
    {
        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        private readonly IExpression _left;
        private readonly IExpression _right;

        public int Interpret() => _left.Interpret() + _right.Interpret();
    }
}
