using BusinessLogic.Services;
using BusinessLogic.Services.Base;
using BusinessLogic.Services.Cart;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extensions
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IActorsService, ActorsService>();
            services.AddScoped<IProducersService, ProducersService>();
            services.AddScoped<ICinemasService, CinemasService>();
            services.AddScoped<IMoviesService, MoviesService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));

            return services;
        }
    }
}
