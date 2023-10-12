namespace FactoryMethodEducationTest.Products
{
    internal interface ITransport
    {
        public string Firm { get; }
        public string Model { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public BodyType bodyType { get; set; }
        public Equipment equipmentType { get; set; }

    }
}
