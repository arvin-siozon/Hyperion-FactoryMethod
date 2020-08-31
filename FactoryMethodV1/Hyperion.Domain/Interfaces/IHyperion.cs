using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Domain.Entities;

namespace Hyperion.Domain.Interfaces
{
     public interface IHyperion
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        double Engine { get; set; }
        bool HasPowerWindows { get; set; }
        string Color { get; set; }

    }
}
