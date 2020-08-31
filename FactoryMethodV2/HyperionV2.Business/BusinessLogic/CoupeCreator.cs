using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionV2.Business.Dto;
using HyperionV2.Domain.Entities;
using HyperionV2.Domain.Interfaces;

namespace HyperionV2.Business.BusinessLogic
{
    public class CoupeCreator : IHyperionCreator
    {
        public IHyperion HyperionModelCreator(CarSpecificationDto dto)
        {
            return new Coupe
            {
                Doors = dto.Doors,
                Engine = dto.Engine,
                HasPowerWindows = dto.HasPowerWindows,
                Color = dto.Color,
                Wheels = dto.Wheels
            };
        }

        public string StartEngine(string message)
        {
            return message;
        }
    }
}
