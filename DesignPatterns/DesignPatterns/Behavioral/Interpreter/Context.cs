namespace DesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        public Context(string input) => Input = input.Split(' ');

        public readonly string[] Input;
    }
}
