using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure
{
  public static class DependencyInjection
    {
        /// <summary>
        /// Register application and infrastructure services into the provided <see cref="IServiceCollection"/>.
        /// Add concrete registrations here (repositories, application services, mappers, etc.).
        /// </summary>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {            
            return services;
        }
    }
}