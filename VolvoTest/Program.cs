using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using VolvoTest.Application;
using VolvoTest.IOC;

namespace VolvoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            IocContainer.Configure(services);
            var provider = services.BuildServiceProvider();
            provider.GetService<ServicesApplication>();

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
