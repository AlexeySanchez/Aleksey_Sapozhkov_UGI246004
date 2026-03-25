using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Dish
{
    public class Dish
    {
        public readonly string Name;

        // свойства
        public string KitchenType { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CookingTime { get; set; }

        public Dish(string name, string kitchenType, string description)
        {
            Name = name;
            KitchenType = kitchenType;
            Description = description;
        }

        //Метод формирует массив из двух строк: первая — название блюда,
        //вторая — подробная информация (кухня, описание, цена, наличие и время приготовления)
        public string[] GetInfo()
        {
            string[] info = new string[2];

            info[0] = Name;

            string availableText;
            if (IsAvailable)
                availableText = "да";
            else
                availableText = "нет";

            info[1] = $"Кухня: {KitchenType}. Описание: {Description}. Цена: {Price}. " +
                      $"Наличие: {availableText}. Время приготовления: {CookingTime} мин.";

            return info;
        }
    }
}
