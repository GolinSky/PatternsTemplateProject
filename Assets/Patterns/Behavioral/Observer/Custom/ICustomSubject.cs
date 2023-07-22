namespace GofPatterns.Patterns.Behavioral.Observer.Custom
{
    public interface ICustomSubject
    {
        void AddObserver(ICustomObserver observer);
        void RemoveObserver(ICustomObserver observer);
    }
    
    public interface ICustomSubject<TState>
    {
        void AddObserver(ICustomObserver<TState> observer);
        void RemoveObserver(ICustomObserver<TState> observer);
    }
}