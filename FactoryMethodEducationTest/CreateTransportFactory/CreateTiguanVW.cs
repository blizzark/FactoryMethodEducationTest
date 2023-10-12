using FactoryMethodEducationTest.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.CreateTransportFactory
{
    internal  class CreateTiguanVW : TransportFactory
    {

        public async override Task<ITransport> CreateTransport(BodyEnum body, EquipmentEnum equipment) => new TiguanVW(body, equipment);


    }
}
