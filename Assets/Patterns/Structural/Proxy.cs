namespace GofPatterns.Patterns.Structural
{
    public interface IProxyBehaviour
    {
        
    }
    
    public interface IProxy<TBehaviour> 
        where TBehaviour:IProxyBehaviour
    {
        TBehaviour Behaviour { get; }
    }

    public abstract class Proxy<TBehaviour>:IProxy<TBehaviour>
        where TBehaviour : IProxyBehaviour
    {
        public TBehaviour Behaviour { get; protected set; }

        protected Proxy(TBehaviour behaviour)
        {
            Behaviour = behaviour;
        }

    }
}