using UnityEngine;

namespace GofPatterns.Examples.Proxy
{
    public static class ProxyMain
    {
        public static void Main()
        {
            MathProxy proxy = new MathProxy(new MathService());
            
            // Do the math
            Debug.Log("4 + 2 = " + proxy.Behaviour.Add(4, 2));
            Debug.Log("4 - 2 = " + proxy.Behaviour.Sub(4, 2));
            Debug.Log("4 * 2 = " + proxy.Behaviour.Mul(4, 2));
            Debug.Log("4 / 2 = " + proxy.Behaviour.Div(4, 2));
        }
    }
}