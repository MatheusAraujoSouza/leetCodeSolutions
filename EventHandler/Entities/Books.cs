using EventHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Entities
{
    internal class Books : IBooks
    {
        public string Name => "Books from eventhandler";
    }
}
