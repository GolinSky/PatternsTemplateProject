namespace GofPatterns.Patterns.Structural
{
    //todo: add template with some yield/async  
    public interface IDecoratorEntity
    {
        void Operation();
    }
    public interface IDecorator:IDecoratorEntity
    {
        
    }

    public abstract class Decorator<TEntity>: IDecorator
        where TEntity : IDecoratorEntity 
    {
        protected TEntity Entity { get; }

        protected Decorator(TEntity entity)
        {
            Entity = entity;
        }

        public virtual void Operation()
        {
            Entity.Operation();
        }
    }
}