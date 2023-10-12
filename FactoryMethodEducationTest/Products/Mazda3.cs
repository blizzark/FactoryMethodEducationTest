namespace FactoryMethodEducationTest.Products
{
    internal class Mazda3 : ITransport
    {
        public string Model { get; }
        public string Firm { get; }
        public string Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;

        internal Mazda3(string model, string firm, string description)
        {
            Model = model;
            Firm = firm;
            Description = description;
        }


    }
}
