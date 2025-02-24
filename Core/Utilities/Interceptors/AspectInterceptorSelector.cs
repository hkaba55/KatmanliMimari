using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;

public class AspectInterceptorSelector : IInterceptorSelector
{
    
    public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
    {
        var clasAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
            (true).ToList();
        var methodAttributes = type.GetMethod(method.Name)
            .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
        clasAttributes.AddRange(methodAttributes);

        return clasAttributes.OrderBy(x => x.Priority).ToArray();
    }
}