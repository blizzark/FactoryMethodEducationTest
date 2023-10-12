using FactoryMethodEducationTest.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.CreateTransportFactory
{
    internal abstract class TransportFactory
    {

        public abstract ITransport CreateTransport(string firm);
    }
}
