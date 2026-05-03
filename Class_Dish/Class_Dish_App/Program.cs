using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Dish;

namespace Class_Dish_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var snack = new Snack(
                "Жульен",
                KitchenType.French,
                "Горячая закуска с грибами",
                SnackType.Hot
            );

            snack.Price = 250;
            snack.IsAvailable = true;
            snack.CookingTime = 15;

            var mainCourse = new MainCourse(
                "Стейк",
                KitchenType.French,
                "Стейк из говядины",
                MainProductType.Meat,
                "картофельное пюре"
            );

            mainCourse.Price = 850;
            mainCourse.IsAvailable = true;
            mainCourse.CookingTime = 30;

            Console.WriteLine("Информация о закуске:");
            foreach (var line in snack.GetInfo())
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            Console.WriteLine("Информация об основном блюде:");
            foreach (var line in mainCourse.GetInfo())
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
