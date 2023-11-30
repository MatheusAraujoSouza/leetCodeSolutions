using EventHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Entities
{
    internal class TaxBrl : ITax
    {
        public double CalculateTax(double value)
        {
            return value * 0.27;
        }
    }
}
