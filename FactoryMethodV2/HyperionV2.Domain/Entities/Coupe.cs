using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionV2.Domain.Interfaces;

namespace HyperionV2.Domain.Entities
{
    public class Coupe : IHyperion
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public double Engine { get; set; }
        public bool HasPowerWindows { get; set; }
        public string Color { get; set; }
    }
}
