using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Domain.Entities
{
    public class Sport : IHyperion
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public double Engine { get; set; }
        public bool HasPowerWindows { get; set; }
        public string Color { get; set; }
       
    }
}
