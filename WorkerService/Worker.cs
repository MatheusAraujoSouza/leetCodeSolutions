using EventHandler.Interfaces;
using System.Collections;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IEnumerable<IBooks> _books;
        private readonly IEnumerable<ITax> _taxes;

        //public Worker(ILogger<Worker> logger, IBooks books)
        //{
        //    _books = new List<IBooks> { books };
        //    _logger = logger;
        //}

        public Worker(ILogger<Worker> logger, IEnumerable<IBooks> books, IEnumerable<ITax> taxes)
        {
            _books = books;
            _taxes = taxes;
            _logger = logger;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _books.ToList().ForEach(book => _logger.LogInformation(book.Name));
                _taxes.ToList().ForEach(tax => _logger.LogInformation(tax.CalculateTax(100).ToString()));
                await Task.Delay(1000, stoppingToken);
                await StopAsync(stoppingToken);
            }
        }
    }
}