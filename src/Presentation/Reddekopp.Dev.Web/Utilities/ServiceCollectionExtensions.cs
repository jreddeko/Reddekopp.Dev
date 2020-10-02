using Microsoft.Extensions.DependencyInjection;
using Reddekopp.Dev.Web.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddekopp.Dev.Web
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServiceImplementations(this IServiceCollection services)
        {
            services.AddTransient<IViewModelFactory, ViewModelFactory>();
        }
    }
}
