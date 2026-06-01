using NUnit.Framework;
using Class_Dish;

namespace Class_Dish.UnitTests
{
    [TestFixture]
    public class DishCompareToTests
    {
        [Test]
        public void CompareTo_DifferentKitchens_SortsByKitchen()
        {
            Dish russianDish = new Dish("Борщ", KitchenType.Russian, "Суп");
            Dish frenchDish = new Dish("Жульен", KitchenType.French, "Закуска");

            Assert.That(russianDish.CompareTo(frenchDish), Is.LessThan(0));
            Assert.That(frenchDish.CompareTo(russianDish), Is.GreaterThan(0));
        }

        [Test]
        public void CompareTo_SameKitchen_SortsByName()
        {
            Dish borscht = new Dish("Борщ", KitchenType.Russian, "Суп");
            Dish pelmeni = new Dish("Пельмени", KitchenType.Russian, "Блюдо из теста и мяса");

            Assert.That(borscht.CompareTo(pelmeni), Is.LessThan(0));
            Assert.That(pelmeni.CompareTo(borscht), Is.GreaterThan(0));
        }

        [Test]
        public void CompareTo_SameDish_ReturnsZero()
        {
            Dish borscht = new Dish("Борщ", KitchenType.Russian, "Суп");
            Dish sameBorscht = new Dish("Борщ", KitchenType.Russian, "Другой рецепт супа");

            Assert.That(borscht.CompareTo(sameBorscht), Is.EqualTo(0));
        }
    }
}
