using System;
using System.Collections.Generic;
using NUnit.Framework;
using Class_Dish;

namespace Class_Dish.UnitTests
{
    [TestFixture]
    public class MenuTests
    {
        private Dish[] dishes = null!;
        private Menu menu = null!;

        [SetUp]
        public void Setup()
        {
            dishes = new Dish[]
            {
                new Snack("Жульен", KitchenType.French, "Горячая закуска с грибами", SnackType.Hot),
                new MainCourse("Плов", KitchenType.CentralAsian, "Рис с мясом", MainProductType.Meat, "овощи"),
                new MainCourse("Стейк", KitchenType.French, "Стейк из говядины", MainProductType.Meat, "картофельное пюре")
            };

            menu = new Menu(new DateTime(2026, 5, 3), dishes);
        }

        [Test]
        public void Constructor_FillsDishList()
        {
            List<Dish> actualDishes = new List<Dish>();

            foreach (Dish dish in menu)
                actualDishes.Add(dish);

            Assert.That(actualDishes.Count, Is.EqualTo(dishes.Length));
            Assert.That(actualDishes[0], Is.SameAs(dishes[0]));
            Assert.That(actualDishes[1], Is.SameAs(dishes[1]));
            Assert.That(actualDishes[2], Is.SameAs(dishes[2]));
        }

        [Test]
        public void Constructor_StringDate_CreatesMenu()
        {
            Menu stringDateMenu = new Menu("03.05.2026", dishes);
            int count = 0;

            foreach (Dish dish in stringDateMenu)
                count++;

            Assert.That(count, Is.EqualTo(3));
        }

        [Test]
        public void IEnumerable_MenuCanBeUsedInForeach()
        {
            int i = 0;

            foreach (Dish dish in menu)
            {
                Assert.That(dish, Is.SameAs(dishes[i]));
                i++;
            }

            Assert.That(i, Is.EqualTo(dishes.Length));
        }
    }
}
