using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDH.Factory
{
    public class SoftwareProductCreator :ProductCreator
    {
        public override IDigitalProduct CreateProduct() => new SoftwareProduct();   
    }
}
