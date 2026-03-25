using Class_Dish;
namespace DishTests
{
    [TestFixture]
    public class DishUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            Dish dish = CreateTestDish();

            Assert.That(dish.Name, Is.EqualTo("Плов"));
            Assert.That(dish.Kitchen, Is.EqualTo(KitchenType.CentralAsian));
            Assert.That(dish.Description, Is.EqualTo("Рис с мясом"));
        }

        [Test]
        public void GetInfoTest()
        {
            Dish dish = CreateTestDish();
            dish.Price = 350;
            dish.IsAvailable = true;
            dish.CookingTime = 25;

            string[] info = dish.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Плов"));
            Assert.That(info[1], Is.EqualTo(
                "Кухня: CentralAsian. Описание: Рис с мясом. Цена: 350. Наличие: да. Время приготовления: 25 мин."
            ));
        }

        private Dish CreateTestDish()
        {
            return new Dish("Плов", KitchenType.CentralAsian, "Рис с мясом");
        }
    }
}
