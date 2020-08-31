using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Domain.Dto;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Business.Base
{
    public interface ICreator<TEntity, TDto>
    {
        TEntity HyperionModelCreator(TDto dto);
        string StartEngine(string welcomeMessage);
    }
}
