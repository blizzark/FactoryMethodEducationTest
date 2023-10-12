using FactoryMethodEducationTest.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.CreateTransportFactory
{
    internal class Mazda3Fabric : TransportFactory
    {
        private string _model = "3";

     
        public override ITransport CreateTransport(string firm)
        {
            return new Mazda3(_model, firm, "Машина фирмы Мазда");
        }
    }
}
