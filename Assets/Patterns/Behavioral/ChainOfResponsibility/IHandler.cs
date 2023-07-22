namespace GofPatterns.Patterns.Behavioral
{
    public interface IHandler:IBaseHandler<IHandler>
    {
        void Handle();
    }

    public interface IHandler<THandleData>:IBaseHandler<IHandler<THandleData>>
    {
        void Handle(THandleData data);
    }
}