using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using DevQuestion.Application;

namespace DevQuestion.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddProgramDependencies(this IServiceCollection services)
    {
        services.AddWebDependencies();
        services.AddApplication();

        return services;
    }
    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {

        services.AddControllers();//controller
        services.AddOpenApi();//openApi

        return services;
    }
}