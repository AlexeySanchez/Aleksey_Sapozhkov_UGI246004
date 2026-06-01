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

            Console.WriteLine();
            Console.WriteLine("Блюда в меню:");
            var menu = new Menu(DateTime.Today, new Dish[] { snack, mainCourse });
            foreach (var dish in menu)
            {
                Console.WriteLine(dish.Name);
            }

            var dishes = new List<Dish>
            {
                new MainCourse(
                    "Плов",
                    KitchenType.CentralAsian,
                    "Рис с мясом",
                    MainProductType.Meat,
                    "овощи"
                ),

                new Snack(
                    "Жульен",
                    KitchenType.French,
                    "Горячая закуска с грибами",
                    SnackType.Hot
                ),

                new Dish(
                    "Борщ",
                    KitchenType.Russian,
                    "Суп со свеклой"
                ),

                new Dish(
                    "Пельмени",
                    KitchenType.Russian,
                    "Блюдо из теста и мяса"
                ),

                new MainCourse(
                    "Паста",
                    KitchenType.Italian,
                    "Паста с соусом",
                    MainProductType.Vegetarian,
                    "сыр"
                )
            };

            Console.WriteLine("Блюда до сортировки:");
            foreach (Dish dish in dishes)
                {
                    Console.WriteLine($"{dish.KitchenName} - {dish.Name}");
                }


            dishes.Sort();

            Console.WriteLine();
            Console.WriteLine("Блюда после сортировки:");
            foreach (Dish dish in dishes)
            {
                Console.WriteLine($"{dish.KitchenName} - {dish.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Проверка Menu через foreach:");

            Menu menu_2 = new Menu(DateTime.Today, dishes);

            foreach (Dish dish in menu_2)
            {
                Console.WriteLine($"В меню есть блюдо: {dish.Name}");
            }


            Console.ReadKey();
        }
    }
}
