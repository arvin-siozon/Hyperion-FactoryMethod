using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion.Business.Base
{
    public class CarFactory<TIHyperion, TProduct> where TProduct : class, TIHyperion, new()
    {
        public static TIHyperion CreateInstance()
        {
            TIHyperion _productInstance;

            _productInstance = new TProduct();

            return _productInstance;
        }
    }
}
