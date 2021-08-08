using Microsoft.Extensions.DependencyInjection;
using RestaurantAPI.Services;
using RestaurantAPI.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Config
{
    public static class RegistrationConfig
    {
        static IServiceCollection _services;
        public static IServiceCollection AddRegistration(IServiceCollection services)
        {
            services.AddSingleton<IDishCollection, DishCollection>();
            return _services = services;
        }
    }
}
