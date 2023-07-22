namespace GofPatterns.Patterns.Behavioral
{
    //todo check examples with impl of IEnumerator  
    public interface Iterator<TIterable>
    {
        bool IsCompleted();
        TIterable GetNext();
        void Reset();
    }
}