using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyperion.Business.Base;
using Hyperion.Domain.Entities;
using Hyperion.Domain.Interfaces;

namespace Hyperion.Business.ProductBusiness
{
    public class ProductCreator
    {
        public IHyperion CreateInstance(List<IHyperion> hyperions)
        {
            IHyperion productInstance = null;

            switch (hyperions.GetType().Name)
            {
                case "Sedan":
                    productInstance = CarFactory<IHyperion, Sedan>.CreateInstance();
                    break;
                case "Coupe":
                    productInstance = CarFactory<IHyperion, Coupe>.CreateInstance();
                    break;
                case "Sport":
                    productInstance = CarFactory<IHyperion, Sport>.CreateInstance();
                    break;
            }
            return productInstance;
        }
    }
}
