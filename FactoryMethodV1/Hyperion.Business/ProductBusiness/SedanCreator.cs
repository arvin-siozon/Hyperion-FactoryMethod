using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Business.Base;
using Hyperion.Domain.Dto;
using Hyperion.Domain.Entities;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Business.ProductBusiness
{
    //Concrete creator
    public class SedanCreator : CreatorBase<IHyperion, CarSpecificationDto>
    {
        public override IHyperion HyperionModelCreator(CarSpecificationDto dto)
        {
            return new Sedan
            {
                Doors = dto.Doors,
                Engine = dto.Engine,
                HasPowerWindows = dto.HasPowerWindows,
                Color = dto.Color,
                Wheels = dto.Wheels
            };
        }
    }
}
