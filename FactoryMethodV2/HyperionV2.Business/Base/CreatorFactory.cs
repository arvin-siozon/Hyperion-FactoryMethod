using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionV2.Business.Base
{
    public class CarFactory<TIHyperionCreator, TProductCreator> where TProductCreator : class, TIHyperionCreator, new()
    {
        TIHyperionCreator _productInstance;
        public TIHyperionCreator CreateInstance()
        {
            _productInstance = new TProductCreator();
            return _productInstance;
        }

        public string StartEngine (string message)
        {
            return message;
        }

    }
}
