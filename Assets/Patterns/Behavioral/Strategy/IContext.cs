namespace GofPatterns.Patterns.Behavioral
{
    //impl using another interface and put in it all behaviour which will be executed by  IStrategy
    public interface IContext:IStrategyBehaviour
    {
        void SetStrategy(IStrategy strategy);
        
    }
}