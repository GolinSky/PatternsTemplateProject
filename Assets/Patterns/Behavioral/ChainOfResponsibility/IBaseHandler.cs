namespace GofPatterns.Patterns.Behavioral.ChainOfResponsibility
{
    public interface IBaseHandler<THandler>
    {
        THandler SetNext(THandler handler);
    }
}