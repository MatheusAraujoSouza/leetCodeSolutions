using EventHandler.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService.domain.Entities;

namespace WorkerService.domain.Extentions
{
    public static class DependencyInjection
    {
        public static void AddBibliaBookService(this IServiceCollection services)
        {
            services.AddBooksService<BibliaBook>();
        }

        public static void AddTaxUsService(this IServiceCollection services)
        {
            services.AddTaxService<TaxUS>();
        }

    }
}
