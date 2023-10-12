using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEducationTest.Products
{
    internal class PoloVW:ITransport
    {
        public string Firm { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public BodyType bodyType { get; set; }
        public Equipment equipmentType { get; set; }

        public PoloVW(BodyEnum body, EquipmentEnum equipment) {
           
            bodyType = new BodyType(body);
            equipmentType = new Equipment(equipment);

        }
    }
}
