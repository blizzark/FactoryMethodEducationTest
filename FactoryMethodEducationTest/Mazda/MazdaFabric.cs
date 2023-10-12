using FactoryMethodEducationTest.CreateTransportFactory;
using FactoryMethodEducationTest.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.Mazda
{
    internal class Mazda : TransportFactory
    {
        public override ITransport CreateTransport(string firm)
        {
            return new MazdaModel3("Машина фирмы Мазда");
        }
    }
}
