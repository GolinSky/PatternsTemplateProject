namespace GofPatterns.Patterns.Creational
{
    //todo: hide ctor somehow - maybe using activator
    public abstract class Singleton<TInstance> where TInstance : new()
    {
        private static TInstance instance;

        public static TInstance Instance //can we use get in static context?
        {
            get
            {
                if (instance == null)
                {
                    instance = new TInstance();
                }

                return instance;
            }

        }

        protected Singleton()
        {
            
        }
    }
}