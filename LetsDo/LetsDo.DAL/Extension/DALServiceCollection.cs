using LetsDo.DAL.Repositories.Abstract;
using LetsDo.DAL.Repositories.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDo.DAL.Extension
{
    public static class DalServiceCollection
    {
        public static IServiceCollection AddDal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;

        }
    }
}
