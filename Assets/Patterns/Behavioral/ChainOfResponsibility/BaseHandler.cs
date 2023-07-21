namespace GofPatterns.Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class BaseHandler<THandler>:IBaseHandler<THandler>
    {
        protected THandler NextHandler { get; private set; }
        
        public THandler SetNext(THandler handler)
        {
            NextHandler = handler;
            return handler;
        }
    }
}