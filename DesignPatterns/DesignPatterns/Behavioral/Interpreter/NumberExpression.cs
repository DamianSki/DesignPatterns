namespace DesignPatterns.Behavioral.Interpreter
{
    public class NumberExpression : IExpression
    {
        public NumberExpression(int number) => _number = number;

        int _number;
        public int Interpret() => _number;
    }
}
