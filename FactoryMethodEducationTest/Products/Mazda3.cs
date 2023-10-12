namespace FactoryMethodEducationTest.Products
{
    internal class MazdaModel3 : Sedan, ITransport
    {
        public string Model { get; }
        public string Firm { get; }
       
        public decimal Price { get; set; } = decimal.Zero;

        internal MazdaModel3(string description):base(description)
        {
            Model = "3";
            Firm = "Mazda";
            Description = description;

        }


    }
}
