using FactoryMethodEducationTest.CreateTransportFactory;
using System.Transactions;

class Program
{
    static void Main()
    {
        var auto = new Mazda3Fabric().CreateTransport("Mazda");

        Console.WriteLine(auto.Firm);
    }
}