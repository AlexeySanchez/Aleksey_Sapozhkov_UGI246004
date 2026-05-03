using NUnit.Framework;
using Class_Dish;

namespace Class_Dish.UnitTests
{
    [TestFixture]
    public class MainCourseTests
    {
        [Test]
        public void ConstructorTest()
        {
            MainCourse mainCourse = GetTestMainCourse();

            Assert.That(mainCourse.Name, Is.EqualTo("Стейк"));
            Assert.That(mainCourse.Kitchen, Is.EqualTo(KitchenType.French));
            Assert.That(mainCourse.Description, Is.EqualTo("Стейк из говядины"));
            Assert.That(mainCourse.ProductType, Is.EqualTo(MainProductType.Meat));
            Assert.That(mainCourse.Garnish, Is.EqualTo("картофельное пюре"));
        }

        [Test]
        public void GetInfo_MainCourse_ReturnsThreeLines()
        {
            MainCourse mainCourse = GetTestMainCourse();

            string[] info = mainCourse.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Стейк"));
            Assert.That(info[1], Is.EqualTo("Кухня: французская. Описание: Стейк из говядины. Цена: 850. Наличие: да. Время приготовления: 30 мин."));
            Assert.That(info[2], Is.EqualTo("Основное блюдо. Тип основного продукта: мясо. Гарнир: картофельное пюре."));
        }

        [TestCase(MainProductType.Meat, "мясо")]
        [TestCase(MainProductType.Fish, "рыба")]
        [TestCase(MainProductType.Vegetarian, "вегетарианское")]
        public void GetInfo_ProductType_ReturnsCorrectRussianText(MainProductType productType, string expectedText)
        {
            MainCourse mainCourse = new MainCourse("Тестовое блюдо", KitchenType.Russian, "Описание", productType, "гарнир");

            string[] info = mainCourse.GetInfo();

            Assert.That(info[2], Does.Contain(expectedText));
        }

        private MainCourse GetTestMainCourse()
        {
            MainCourse mainCourse = new MainCourse("Стейк", KitchenType.French, "Стейк из говядины", MainProductType.Meat, "картофельное пюре");
            mainCourse.Price = 850;
            mainCourse.IsAvailable = true;
            mainCourse.CookingTime = 30;
            return mainCourse;
        }
    }
}
