using System;

namespace Class_Dish
{
    public class Dish : IComparable<Dish>
    {
        public readonly string Name;

        //Свойства базового класса блюда
        public KitchenType Kitchen { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CookingTime { get; set; }

        public Dish(string name, KitchenType kitchen, string description)
        {
            Name = name;
            Kitchen = kitchen;
            Description = description;
        }

        //Сортировка блюд: сначала по кухне, затем по названию
        public int CompareTo(Dish other)
        {
            if (other == null)
                return 1;

            int kitchenComparison = Kitchen.CompareTo(other.Kitchen);
            if (kitchenComparison != 0)
                return kitchenComparison;

            return string.Compare(Name, other.Name, StringComparison.CurrentCulture);
        }

        //Метод virtual можно переопределять в производных классах через override
        //Метод возвращает массив из двух строк
        public virtual string[] GetInfo()
        {
            string[] info = new string[2];

            info[0] = Name;

            string availableText;
            if (IsAvailable)
                availableText = "да";
            else
                availableText = "нет";

            info[1] = $"Кухня: {GetKitchen()}. Описание: {Description}. Цена: {Price}. " +
                      $"Наличие: {availableText}. Время приготовления: {CookingTime} мин.";

            return info;
        }

        private string GetKitchen()
        {
            if (Kitchen == KitchenType.Russian)
                return "русская";

            if (Kitchen == KitchenType.Caucasian)
                return "кавказская";

            if (Kitchen == KitchenType.Italian)
                return "итальянская";

            if (Kitchen == KitchenType.French)
                return "французская";

            if (Kitchen == KitchenType.CentralAsian)
                return "среднеазиатская";

            if (Kitchen == KitchenType.Eastern)
                return "восточная";

            return "неизвестная";
        }

        public string KitchenName => GetKitchen();
    }
}
