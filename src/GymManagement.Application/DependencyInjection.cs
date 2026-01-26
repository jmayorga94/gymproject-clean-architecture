using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application
{
  public static class DependencyInjection
    {
        /// <summary>
        /// Register application and infrastructure services into the provided <see cref="IServiceCollection"/>.
        /// Add concrete registrations here (repositories, application services, mappers, etc.).
        /// </summary>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            if (services is null) throw new ArgumentNullException(nameof(services));

            services.AddMediatR(options=> options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection)));
            return services;
        }
    }
}