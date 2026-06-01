namespace Class_Dish
{
    public class Snack : Dish
    {
        public SnackType Type { get; set; }

        public Snack(string name, KitchenType kitchen, string description, SnackType type)
            : base(name, kitchen, description)
        {
            Type = type;
        }

        public override string[] GetInfo()
        {
            string[] dishInfo = base.GetInfo();
            string[] info = new string[3];

            info[0] = dishInfo[0];
            info[1] = dishInfo[1];
            info[2] = $"Закуска. Тип: {GetSnackType()}.";

            return info;
        }

        private string GetSnackType()
        {
            if (Type == SnackType.Hot)
                return "горячая";

            return "холодная";
        }
    }
}
