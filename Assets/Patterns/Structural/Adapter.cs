namespace GofPatterns.Patterns.Structural
{
    public interface ITarget<out TResult>
    {
        TResult GetRequest();
    }
    
    public interface Adaptee<out TResult>
    {
        TResult GetSpecificRequest();
    }
    
    public abstract class Adapter<TResult, TAdaptee>: ITarget<TResult>
        where TAdaptee:Adaptee<TResult>
    {
        protected TAdaptee Adaptee { get; }

        protected Adapter(TAdaptee adaptee)
        {
            Adaptee = adaptee;
        }

        public TResult GetRequest()
        {
            return Adaptee.GetSpecificRequest();
        }
    }
}