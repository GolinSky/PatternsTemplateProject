namespace GofPatterns.Patterns.Creational
{
    public interface IAbstractFactory<out TProductA, out TProductB>
    {
        TProductA CreateProductA();
        TProductB CreateProductB();
    }
}
