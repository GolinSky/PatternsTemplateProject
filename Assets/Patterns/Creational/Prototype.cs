namespace GofPatterns.Patterns.Creational
{
    public interface IPrototype
    {
        
    }
    public interface IPrototype<T>:IPrototype 
        where T:IPrototype
    {
        T Clone();
    }
    
    //todo:check this
    public abstract class Prototype<TPrototype>:IPrototype<TPrototype>
        where TPrototype: class, IPrototype
    {
        public virtual TPrototype Clone()
        {
            return MemberwiseClone() as TPrototype;
        }
    }
}