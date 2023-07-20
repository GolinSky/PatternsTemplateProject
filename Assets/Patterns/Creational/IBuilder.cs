namespace GofPatterns.Patterns.Creational
{
    public interface IBuilder<out TProduct>
    {
        TProduct Build();
    }
}