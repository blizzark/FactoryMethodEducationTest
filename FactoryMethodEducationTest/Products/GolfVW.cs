using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.Products
{
    internal class GolfVW : ITransport
    {
        public string Firm { get; }
        public string Model { get;  }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public BodyType bodyType { get; set; }
        public Equipment equipmentType { get; set; }

        public GolfVW(BodyEnum body, EquipmentEnum equipment)
        {
            Firm = "Volkswagen";
            Model = "Golf";
            Description = "Golf - лучшая модель для души";
            Price = 800000;
            bodyType = new BodyType(body);
            equipmentType = new Equipment(equipment);

        }
    }
}
