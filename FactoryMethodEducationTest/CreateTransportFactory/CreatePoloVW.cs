using FactoryMethodEducationTest.Products;

namespace FactoryMethodEducationTest.CreateTransportFactory
{
    internal class CreatePoloVW : TransportFactory
    {
        private string _firm = "Volkswagen";
        private string _model = "Polo";
        private string _descriopion = "Polo - лучшая модель для такси";
        private decimal _price = 1000000;


        public async override Task<ITransport> CreateTransport(BodyEnum body, EquipmentEnum equipment)
        {
            await Task.Delay(1000);
            return new PoloVW(body, equipment) // т.е. передача мб из этого класса
            {
                Firm = _firm,
                Model = _model,
                Description = "Polo - лучшая модель для такси",
                Price = _price
            };
        }

    }
}
