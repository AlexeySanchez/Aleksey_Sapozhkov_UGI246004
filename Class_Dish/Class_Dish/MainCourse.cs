namespace Class_Dish
{
    public class MainCourse : Dish
    {
        public MainProductType ProductType { get; set; }
        public string Garnish { get; set; }

        public MainCourse(string name, KitchenType kitchen, string description,
            MainProductType productType, string garnish)
            : base(name, kitchen, description)
        {
            ProductType = productType;
            Garnish = garnish;
        }

        public override string[] GetInfo()
        {
            string[] dishInfo = base.GetInfo();
            string[] info = new string[3];

            info[0] = dishInfo[0];
            info[1] = dishInfo[1];
            info[2] = $"Основное блюдо. Тип основного продукта: {GetProductType()}. Гарнир: {Garnish}.";

            return info;
        }

        private string GetProductType()
        {
            if (ProductType == MainProductType.Meat)
                return "мясо";

            if (ProductType == MainProductType.Fish)
                return "рыба";

            return "вегетарианское";
        }
    }
}
