namespace GofPatterns.Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler:BaseHandler<IHandler>,IHandler
    {
        public virtual void Handle()
        {
            NextHandler?.Handle();
        }
    }
    
    public abstract class Handler<THandleData>:BaseHandler<IHandler<THandleData>>, IHandler<THandleData>
    {
        public void Handle(THandleData data)
        {
            NextHandler?.Handle(data);
        }
    }
}