using AvaloniaCross.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaCross;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddTransient<MainViewModel>();
    }
}