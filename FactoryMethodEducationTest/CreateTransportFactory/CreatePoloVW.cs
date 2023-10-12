﻿using FactoryMethodEducationTest.Products;

namespace FactoryMethodEducationTest.CreateTransportFactory
{
    internal class CreatePoloVW : TransportFactory
    {

        public async override Task<ITransport> CreateTransport(BodyEnum body, EquipmentEnum equipment) => new PoloVW(body, equipment)
        {
            Firm = "Volkswagen",
            Model = "Polo",
            Description = "Polo - лучшая модель для такси",
            Price = 1000000
        };


    }
}