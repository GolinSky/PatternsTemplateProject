using GofPatterns.Patterns.Structural;

namespace GofPatterns.Examples.Proxy
{
    public class MathProxy:Proxy<IMathService>
    {
        public MathProxy(IMathService behaviour) : base(behaviour)
        {
        }

    }
}