using GofPatterns.Patterns.Structural;

namespace GofPatterns.Examples.Proxy
{
    public interface IMathService:IProxyBehaviour
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
    
    public class MathService:IMathService
    {
        public double Add(double x, double y) => x + y; 
        public double Sub(double x, double y) => x - y; 
        public double Mul(double x, double y) => x * y; 
        public double Div(double x, double y) => x / y; 
    }
}