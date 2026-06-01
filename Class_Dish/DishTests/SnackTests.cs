using NUnit.Framework;
using Class_Dish;

namespace Class_Dish.UnitTests
{
    [TestFixture]
    public class SnackTests
    {
        [Test]
        public void ConstructorTest()
        {
            Snack snack = GetTestSnack();

            Assert.That(snack.Name, Is.EqualTo("Жульен"));
            Assert.That(snack.Kitchen, Is.EqualTo(KitchenType.French));
            Assert.That(snack.Description, Is.EqualTo("Горячая закуска с грибами"));
            Assert.That(snack.Type, Is.EqualTo(SnackType.Hot));
        }

        [Test]
        public void GetInfo_Snack_ReturnsThreeLines()
        {
            Snack snack = GetTestSnack();

            string[] info = snack.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Жульен"));
            Assert.That(info[1], Is.EqualTo("Кухня: французская. Описание: Горячая закуска с грибами. Цена: 250. Наличие: да. Время приготовления: 15 мин."));
            Assert.That(info[2], Is.EqualTo("Закуска. Тип: горячая."));
        }

        [TestCase(SnackType.Hot, "Закуска. Тип: горячая.")]
        [TestCase(SnackType.Cold, "Закуска. Тип: холодная.")]
        public void GetInfo_SnackType_ReturnsCorrectRussianText(SnackType type, string expected)
        {
            Snack snack = new Snack("Тестовая закуска", KitchenType.Russian, "Описание", type);

            string[] info = snack.GetInfo();

            Assert.That(info[2], Is.EqualTo(expected));
        }

        private Snack GetTestSnack()
        {
            Snack snack = new Snack("Жульен", KitchenType.French, "Горячая закуска с грибами", SnackType.Hot);
            snack.Price = 250;
            snack.IsAvailable = true;
            snack.CookingTime = 15;
            return snack;
        }
    }
}
