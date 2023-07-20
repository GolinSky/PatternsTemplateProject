namespace GofPatterns.Patterns.Creational
{
    public interface ICreator<TProduct>
    {
        TProduct FactoryMethod();
    }
}