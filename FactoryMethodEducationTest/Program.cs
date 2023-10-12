using FactoryMethodEducationTest.CreateTransportFactory;
using FactoryMethodEducationTest.Products;
using System.Transactions;



class Program
{
    static void Main()
    {
        var VW = new CreatePoloVW().CreateTransport(BodyEnum.Sedan, EquipmentEnum.Comfort);

        Console.WriteLine(VW.Firm);
    }
}