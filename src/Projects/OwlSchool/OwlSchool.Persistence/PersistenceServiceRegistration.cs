using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;
using OwlSchool.Persistence.Repositories;
using Persistence.Repositories;

namespace OwlSchool.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,        IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("OwlSchoolConnectionString")));

       
        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
      
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
     
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
       
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
        
        services.AddScoped<IClassRepository, ClassRepository>();

        return services;
    }
}