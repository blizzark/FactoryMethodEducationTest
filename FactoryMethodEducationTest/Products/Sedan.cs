using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethodEducationTest.Products
{
    internal class Sedan
    {
        public string Description { get; set; }

        public Sedan(string desc) => Description = desc;
    }
}
