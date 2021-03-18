using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class TauxChange
    {
        public IDictionary<string, double> rates { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
    }

}
