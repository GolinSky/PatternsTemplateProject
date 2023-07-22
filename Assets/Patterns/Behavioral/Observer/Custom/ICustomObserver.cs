namespace GofPatterns.Patterns.Behavioral.Observer.Custom
{
    public interface ICustomObserver
    {
        void Notify();
    }
    
    public interface ICustomObserver<TState>
    {
        void Notify(TState state);
    }
}