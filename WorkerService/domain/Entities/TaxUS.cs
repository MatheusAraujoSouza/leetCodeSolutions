using EventHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.domain.Entities
{
    internal class TaxUS : ITax
    {
        private readonly IEnumerable<IBooks> _books;
        public TaxUS(IEnumerable<IBooks> books)
        {
            _books = books;
        }
        public double CalculateTax(double value)
        {
            if (_books.Any(b => b.Name == BibliaBook.NameBook))
                return value;
            return value * 0.15;
        }
    }
}
