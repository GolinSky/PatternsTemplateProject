namespace GofPatterns.Patterns.Structural
{
    public interface IFlyweight<THardData>
    {
        void SetData(THardData data);
    }

    public interface IFlyweightFactory<THardData, in TKey>
    {
        IFlyweight<THardData> GetFlyweight(TKey key);
    }

    public abstract class FlyweightFactory<THardData, TKey>: IFlyweightFactory<THardData, TKey>
    {
        protected THardData HardData { get; }

        protected FlyweightFactory(THardData hardData)
        {
            HardData = hardData;
        }
        public IFlyweight<THardData> GetFlyweight(TKey key)
        {
            var flyweight = Construct(key);
            flyweight.SetData(HardData);
            return flyweight;
        }

        protected abstract IFlyweight<THardData> Construct(TKey key);
    }
}