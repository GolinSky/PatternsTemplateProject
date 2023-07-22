namespace GofPatterns.Patterns.Behavioral
{
    public interface InterpreterExpression<in TContext>
    {
        void Interpret(TContext context);
    }
}