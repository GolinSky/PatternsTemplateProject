namespace GofPatterns.Patterns.Structural
{
    /// <summary>
    /// Bridge pattern
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IAbstraction<TResult>
    {
        TResult Operation();
    }
    
    public interface IImplementation<TResult>
    {
        TResult OperationImplementation();
    }
    
    
    public abstract class Abstraction<TResult>:IAbstraction<TResult>
    {
        protected IImplementation<TResult> Implementation { get;  }

        protected Abstraction(IImplementation<TResult> implementation)
        {
            Implementation = implementation;
        }

        public virtual TResult Operation()
        {
            return Implementation.OperationImplementation();
        }
    }
}