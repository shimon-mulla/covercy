using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.BE
{
    public class PeriodicElement
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public double Weight { get; set; }
        public string Symbol { get; set; }
    }
}
