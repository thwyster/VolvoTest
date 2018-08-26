using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Application;
using VolvoTest.Domain.Interfaces;
using VolvoTest.Domain.Services;
using VolvoTest.Repository;

namespace VolvoTest.IOC
{
    public static class IocContainer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IRepository, RepositoryVehicles>();
            services.AddTransient<IServicesDO, ServicesDO>();
            services.AddSingleton<ServicesApplication>();
        }
    }
}
