using ServiceStack;
using TodoApp.ServiceModel;
using System;

namespace TodoApp.ServiceInterface;

public class MyServices : Service
{
    public static string AssertName(string Name) => Name.IsNullOrEmpty() 
        ? throw new ArgumentNullException(nameof(Name))
        : Name;

    public object Any(Hello request) =>
        new HelloResponse { Result = $"Hello, {AssertName(request.Name)}!" };

    public object Any(HelloSecure request) => 
        new HelloResponse { Result = $"Hello, {AssertName(request.Name)}!" };
}
