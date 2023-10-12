using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.Products
{
    internal class TiguanVW : ITransport
    {
        public string Firm { get; }
        public string Model { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public BodyType bodyType { get; set; }
        public Equipment equipmentType { get; set; }

        public TiguanVW(BodyEnum body, EquipmentEnum equipment)
        {
            Firm = "Volkswagen";
            Model = "Tiguan";
            Description = "Tiguan - лучшая модель для дачи";
            Price = 800000;
            bodyType = new BodyType(body);
            equipmentType = new Equipment(equipment);

        }
    }
}
