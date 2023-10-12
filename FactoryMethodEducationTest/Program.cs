using FactoryMethodEducationTest.CreateTransportFactory;
using FactoryMethodEducationTest.Products;



class Program
{
    static async Task Main()
    {
        var VW = new CreatePoloVW().CreateTransport(BodyEnum.Sedan, EquipmentEnum.Comfort);

        Console.WriteLine(">> Добро пожаловать в салон Volkswagen <<");

        Console.WriteLine(">> Выберите комплектацию автомобиля:\n" +
             "\t> Базовая - б\n" +
           "\t> Комфорт - к \n" +
           "\t> Бизнес - п \n" +
           ">>Ваш выбор:");

        EquipmentEnum equipmentEnum;

        switch (Console.ReadLine()?.ToLower())
        {
            case "б":
                equipmentEnum = EquipmentEnum.Base;
                break;
            case "к":
                equipmentEnum = EquipmentEnum.Comfort;
                break;
            case "п":
                equipmentEnum = EquipmentEnum.Bisnes;
                break;
            default:
                Console.WriteLine(">>  Такого варианта нет");
                return;

        }

        Console.WriteLine(">> Выберите интерисующую вас модель: <<");
        Console.WriteLine(
            "\t> Поло - п \n" +
            "\t> Гольф - г \n" +
            "\t> Тигуан - т \n" +
            ">> Ваш выбор:");
        BodyEnum bodyEnum;
        Task<ITransport> transport;
        switch (Console.ReadLine()?.ToLower()) {
            case "п":
                Console.WriteLine("\t>> Начинаем сборку <<");
                Thread.Sleep(1000);
                bodyEnum = BodyEnum.Sedan;
                transport = new CreatePoloVW().CreateTransport(bodyEnum, equipmentEnum);
 
                break;
            case "г":
                Console.WriteLine("\t>> Начинаем предпродажную подготовку <<");
                Thread.Sleep(1000);
                bodyEnum = BodyEnum.Hatchback;
                transport = new CreateGolfVW().CreateTransport(bodyEnum, equipmentEnum);
           
                break;
            case "т":
                Console.WriteLine("\t>> Ищем автомобиль <<");
                bodyEnum = BodyEnum.SUV;
                transport = new CreateTiguanVW().CreateTransport(bodyEnum, equipmentEnum);
            
                break;
            default:
                Console.WriteLine(">>  Такого варианта нет");
                return;                

        }
     
        Console.WriteLine("\t>> Подождите <<");
       await transport; // чисто просто так, оно не работает :з 
        Console.WriteLine($">> Поздравляем с выбором {transport.Result.Firm} {transport.Result.Model}<<\n" +
            $">> {transport.Result.Description} << \n" +
            $">> Описание комплектации: {transport.Result.equipmentType.Description} <<\n" +
            $">> Описание типа кузова: {transport.Result.bodyType.Description} \n" +
            $">> Цена: {transport.Result.Price}\n\n");




    }
}