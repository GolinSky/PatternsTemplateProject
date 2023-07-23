namespace GofPatterns.Patterns.Behavioral
{
    public abstract class Context:IContext
    {
        protected IStrategy Strategy { get; private set; }
        
        public virtual void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }
        
    }
}