namespace FactoryMethodEducationTest.Products
{
    enum EquipmentEnum
    {
        Base,
        Comfort,
        Bisnes
    }

    internal class Equipment
    {
        public string EquipmentName { get; }
        public string Description { get; }
        public bool AirСonditioner { get; }
        public bool HeatedSeats { get; }
        public bool WindowLifters { get; }
        public Equipment(EquipmentEnum type)
        {
            // согласен, так лучше видно, что в какой комплектации 
            switch (type)
            {
                case EquipmentEnum.Base:
                    EquipmentName = "Базовая комплектация";
                    Description = "Самая обычная комплектация";
                    AirСonditioner = false;
                    HeatedSeats = false;
                    WindowLifters = false;
                    break;
                case EquipmentEnum.Comfort:
                    EquipmentName = "Комплектация комфорт";
                    Description = "Комплектация среднего сегмента";
                    AirСonditioner = false;
                    HeatedSeats = true;
                    WindowLifters = true;
                    break;
                case EquipmentEnum.Bisnes:
                    EquipmentName = "Комплектация бизнес";
                    Description = "Топовая комплектация для бизнесменов";
                    AirСonditioner = true;
                    HeatedSeats = true;
                    WindowLifters = true;
                    break;
                default:
                    throw new ArgumentException("");

            }

            //Description = type switch
            //{
            //    EquipmentEnum.Base => "Самая обычная комплектация",
            //    EquipmentEnum.Comfort => "Комплектация среднего сегмента",
            //    EquipmentEnum.Bisnes => "Топовая комплектация",
            //    _ => ""
            //};
            //AirСonditioner = type switch
            //{
            //    EquipmentEnum.Base => false,
            //    EquipmentEnum.Comfort => false,
            //    EquipmentEnum.Bisnes => true,
            //    _ => false
            //};
            //HeatedSeats = type switch
            //{
            //    EquipmentEnum.Base => false,
            //    EquipmentEnum.Comfort => true,
            //    EquipmentEnum.Bisnes => true,
            //    _ => false
            //};
            //WindowLifters = type switch
            //{
            //    EquipmentEnum.Base => false,
            //    EquipmentEnum.Comfort => false,
            //    EquipmentEnum.Bisnes => true,
            //    _ => false
            //};
        }
    }
}
