    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH.Factory
{
    public abstract class ProductCreator
    {
        public abstract IDigitalProduct CreateProduct();
    }

}
