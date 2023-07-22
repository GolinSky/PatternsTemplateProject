namespace GofPatterns.Patterns.Behavioral
{
    public interface IBaseHandler<THandler>
    {
        THandler SetNext(THandler handler);
    }
}