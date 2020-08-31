using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Business.Base;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Business.Base
{
    //Creator
    public class CarCreator<TCreator, TEntity, TDto> : CreatorBase<TEntity, TDto>
        where TCreator : CreatorBase<TEntity, TDto>, new()
    {
        private readonly TCreator _instance = new TCreator();

        public override TEntity HyperionModelCreator(TDto dto)
        {
            return _instance.HyperionModelCreator(dto);
        }
   
    }
}
