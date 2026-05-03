using NUnit.Framework;
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
                "Кухня: среднеазиатская. Описание: Рис с мясом. Цена: 350. Наличие: да. Время приготовления: 25 мин."
            ));
        }

        [Test]
        public void SnackConstructorTest()
        {
            Snack snack = CreateTestSnack();

            Assert.That(snack.Name, Is.EqualTo("Жульен"));
            Assert.That(snack.Kitchen, Is.EqualTo(KitchenType.French));
            Assert.That(snack.Description, Is.EqualTo("Горячая закуска с грибами"));
            Assert.That(snack.Type, Is.EqualTo(SnackType.Hot));
        }

        [Test]
        public void SnackGetInfoTest()
        {
            Snack snack = CreateTestSnack();
            snack.Price = 250;
            snack.IsAvailable = true;
            snack.CookingTime = 15;

            string[] info = snack.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Жульен"));
            Assert.That(info[1], Is.EqualTo(
                "Кухня: французская. Описание: Горячая закуска с грибами. Цена: 250. Наличие: да. Время приготовления: 15 мин."
            ));
            Assert.That(info[2], Is.EqualTo("Закуска. Тип: горячая."));
        }

        [TestCase(SnackType.Hot, "Закуска. Тип: горячая.")]
        [TestCase(SnackType.Cold, "Закуска. Тип: холодная.")]
        public void SnackGetInfo_Type_ReturnsCorrectText(SnackType type, string expectedText)
        {
            Snack snack = new Snack("Тестовая закуска", KitchenType.Russian, "Описание", type);

            string[] info = snack.GetInfo();

            Assert.That(info[2], Is.EqualTo(expectedText));
        }

        [Test]
        public void MainCourseConstructorTest()
        {
            MainCourse mainCourse = CreateTestMainCourse();

            Assert.That(mainCourse.Name, Is.EqualTo("Стейк"));
            Assert.That(mainCourse.Kitchen, Is.EqualTo(KitchenType.French));
            Assert.That(mainCourse.Description, Is.EqualTo("Стейк из говядины"));
            Assert.That(mainCourse.ProductType, Is.EqualTo(MainProductType.Meat));
            Assert.That(mainCourse.Garnish, Is.EqualTo("картофельное пюре"));
        }

        [Test]
        public void MainCourseGetInfoTest()
        {
            MainCourse mainCourse = CreateTestMainCourse();
            mainCourse.Price = 850;
            mainCourse.IsAvailable = true;
            mainCourse.CookingTime = 30;

            string[] info = mainCourse.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Стейк"));
            Assert.That(info[1], Is.EqualTo(
                "Кухня: французская. Описание: Стейк из говядины. Цена: 850. Наличие: да. Время приготовления: 30 мин."
            ));
            Assert.That(info[2], Is.EqualTo(
                "Основное блюдо. Тип основного продукта: мясо. Гарнир: картофельное пюре."
            ));
        }

        [TestCase(MainProductType.Meat, "мясо")]
        [TestCase(MainProductType.Fish, "рыба")]
        [TestCase(MainProductType.Vegetarian, "вегетарианское")]
        public void MainCourseGetInfo_ProductType_ReturnsCorrectText(MainProductType productType, string expectedText)
        {
            MainCourse mainCourse = new MainCourse("Тестовое блюдо", KitchenType.Russian, "Описание", productType, "рис");

            string[] info = mainCourse.GetInfo();

            Assert.That(info[2], Does.Contain(expectedText));
        }

        private Dish CreateTestDish()
        {
            return new Dish("Плов", KitchenType.CentralAsian, "Рис с мясом");
        }

        private Snack CreateTestSnack()
        {
            return new Snack("Жульен", KitchenType.French, "Горячая закуска с грибами", SnackType.Hot);
        }

        private MainCourse CreateTestMainCourse()
        {
            return new MainCourse("Стейк", KitchenType.French, "Стейк из говядины", MainProductType.Meat, "картофельное пюре");
        }
    }
}
