using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandler.Entities;
using EventHandler.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EventHandler.Extentions
{
    public static class DependencyInjection
    {
        public static void AddBooksService<T>(this IServiceCollection services)  where T : class, IBooks
        {
            services.AddTransient<IBooks, T>();
        }

        public static void AddBooksService(this IServiceCollection services)
        {
            services.AddBooksService<Books>();
        }

        public static void AddTaxService<T>(this IServiceCollection services) where T : class, ITax
        {
            services.AddTransient<ITax, T>();
        }

        public static void AddTaxService(this IServiceCollection services)
        {
            services.AddTaxService<TaxBrl>();
        }
    }
}
