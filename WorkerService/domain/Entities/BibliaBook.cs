using EventHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.domain.Entities
{
    internal class BibliaBook : IBooks
    {
        public const string NameBook = "Biblia";
        public string Name => NameBook;
    }
}
