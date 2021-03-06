using System;
using Kubeless.Functions;
using System.Threading.Tasks;

public class module
{
    public Task<object> handler(Event k8Event, Context k8Context)
    {
        var n = int.Parse(k8Event.Data.ToString());

        return Task.FromResult<object>(fibonacci(n));
    }
    
    public int fibonacci(int n)
    {
        if ((n == 0) || (n == 1))
            return n;
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}