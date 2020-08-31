using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperionV2.Business.Dto;
using HyperionV2.Domain.Interfaces;

namespace HyperionV2.Business
{
    public interface IHyperionCreator
    {
        IHyperion HyperionModelCreator(CarSpecificationDto dto);
        string StartEngine(string message);
    }
}
