using WorkerService;
using EventHandler.Extentions;
using WorkerService.domain.Entities;
using WorkerService.domain.Extentions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddBooksService();
        services.AddTaxService();
        services.AddTaxUsService();
        services.AddBibliaBookService();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
