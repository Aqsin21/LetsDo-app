using LetsDo.DAL.Repositories.Abstract;
using LetsDo.DAL.Repositories.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace LetsDo.DAL.Extension
{
    public static class DalServiceCollection
    {
        public static IServiceCollection AddDal(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;

        }
    }
}
