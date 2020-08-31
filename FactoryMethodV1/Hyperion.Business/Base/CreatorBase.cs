using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion.Business.Base
{
    public abstract class CreatorBase<TEntity, TDto>
    {
        public abstract TEntity HyperionModelCreator(TDto dto);

        public virtual string StartEngine(string welcomeMessage)
        {
            return welcomeMessage;
        }
    }
}
