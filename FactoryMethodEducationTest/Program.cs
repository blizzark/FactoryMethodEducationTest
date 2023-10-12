using FactoryMethodEducationTest.CreateTransportFactory;
using System.Transactions;
using FactoryMethodEducationTest.Mazda;

class Program
{
    static void Main()
    {
        var auto = new Mazda().CreateTransport("Mazda");

        Console.WriteLine(auto.Firm);
    }
}