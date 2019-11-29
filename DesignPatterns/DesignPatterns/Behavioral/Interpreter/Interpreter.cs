namespace DesignPatterns.Behavioral.Interpreter
{
    public class Interpreter
    {
        private int position = 0;

        IExpression Execute(Context context)
        {
            if (position == context.Input.Length)
                return null;

            int number;
            if (int.TryParse(context.Input[position], out number))
            {
                return new NumberExpression(number);
            }
            else
                return ReadNonTerminal(context);
        }

        private IExpression ReadNonTerminal(Context context)
        {
            var oper = context.Input[position++];

            IExpression exp1 = Execute(context);
            IExpression exp2 = Execute(context);

            switch (oper)
            {
                case "+":
                    return new AddExpression(exp1, exp2);
                case "-":
                    return new SubExpression(exp1, exp2);
                default:
                    return null;
            }
        }
    }
}
