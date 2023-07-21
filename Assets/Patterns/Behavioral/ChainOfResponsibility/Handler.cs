namespace GofPatterns.Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler:BaseHandler<IHandler>,IHandler
    {
        protected abstract bool CanHandleRequest { get; }

        public virtual void Handle()
        {
            if (CanHandleRequest)
            {
                NextHandler?.Handle();
            }
            else
            {
                OnHandle();
            }
        }

        protected abstract void OnHandle();
    }
    
    public abstract class Handler<THandleData>:BaseHandler<IHandler<THandleData>>, IHandler<THandleData>
    {

        public void Handle(THandleData data)
        {
            if (CanHandleRequest(data))
            {
                NextHandler?.Handle(data);
            }
            else
            {
                OnHandle(data);
            }
        }

        protected abstract void OnHandle(THandleData handle);
        protected abstract bool CanHandleRequest(THandleData data);

    }
}