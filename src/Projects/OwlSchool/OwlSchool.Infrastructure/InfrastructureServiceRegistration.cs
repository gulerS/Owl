using Microsoft.Extensions.DependencyInjection;
using OwlSchool.Application.Services.ImageService;
using OwlSchool.Infrastructure.ImageService;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IImageService, CloudinaryImageServiceAdapter>();
        return services;
    }
}