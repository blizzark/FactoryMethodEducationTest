using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.Products
{
    enum BodyEnum
    {
        Sedan,
        Hatchback,
        SUV
    }

    internal class BodyType
    {
        public string BodyName { get; set; }
        public string Description { get; }
        public BodyType(BodyEnum bodyType) {
            BodyName = bodyType switch
            {
                BodyEnum.Sedan => "Седан",
                BodyEnum.Hatchback => "Хэтчбек",
                BodyEnum.SUV => "Внедорожник",
                _ => ""
            };

            Description = bodyType switch
            {
                BodyEnum.Sedan => "Предназначен для городской езды",
                BodyEnum.Hatchback => "Хорош для личного пользования",
                BodyEnum.SUV => "Подойдёт для дачи",
                _ => ""
            };
        }
    }
}
