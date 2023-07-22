namespace GofPatterns.Patterns.Behavioral
{
    public interface IAbstractCollection<TIterable>
    {
        Iterator<TIterable> CreateIterator();
    }
}