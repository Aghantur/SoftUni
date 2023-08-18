using NUnit.Framework;
using VendingRetail;

namespace VendingRetailTests
{
    [TestFixture]
    public class CoffeeMatTests
    {
        private CoffeeMat coffeeMat;

        [SetUp]
        public void SetUp()
        {
            coffeeMat = new CoffeeMat(1000, 5);
        }

        [Test]
        public void FillWaterTank_WhenWaterTankIsEmpty_FillsWaterTank()
        {
            string result = coffeeMat.FillWaterTank();

            Assert.AreEqual("Water tank is filled with 1000ml", result);
            Assert.AreEqual(1000, coffeeMat.WaterCapacity);
        }

        [Test]
        public void AddDrink_WhenButtonsAvailable_AddsDrink()
        {
            bool result = coffeeMat.AddDrink("Espresso", 2.5);

            Assert.IsTrue(result);
        }

        [Test]
        public void AddDrink_WhenButtonsNotAvailable_ReturnsFalse()
        {
            coffeeMat.AddDrink("Espresso", 2.5);
            coffeeMat.AddDrink("Cappuccino", 3.0);
            coffeeMat.AddDrink("Latte", 3.5);
            coffeeMat.AddDrink("Mocha", 4.0);
            coffeeMat.AddDrink("Americano", 2.0);

            bool result = coffeeMat.AddDrink("Macchiato", 3.2);

            Assert.IsFalse(result);
        }

        [Test]
        public void BuyDrink_WhenDrinkAvailableAndEnoughWater_BuysDrink()
        {
            coffeeMat.AddDrink("Espresso", 2.5);

            string result = coffeeMat.BuyDrink("Espresso");

            Assert.AreEqual("Your bill is 2.50$", result);
            Assert.AreEqual(2.5, coffeeMat.Income);
        }

        [Test]
        public void BuyDrink_WhenDrinkNotAvailable_ReturnsErrorMessage()
        {
            string result = coffeeMat.BuyDrink("Latte");

            Assert.AreEqual("Latte is not available!", result);
            Assert.AreEqual(0, coffeeMat.Income);
        }

        [Test]
        public void BuyDrink_WhenNotEnoughWater_ReturnsErrorMessage()
        {
            coffeeMat.AddDrink("Espresso", 2.5);
            coffeeMat.AddDrink("Cappuccino", 3.0);

            string result = coffeeMat.BuyDrink("Espresso");

            Assert.AreEqual("CoffeeMat is out of water!", result);
            Assert.AreEqual(0, coffeeMat.Income);
        }

        [Test]
        public void CollectIncome_WhenCalled_ResetsIncome()
        {
            coffeeMat.AddDrink("Espresso", 2.5);
            coffeeMat.BuyDrink("Espresso");

            double collectedIncome = coffeeMat.CollectIncome();

            Assert.AreEqual(2.5, collectedIncome);
            Assert.AreEqual(0, coffeeMat.Income);
        }
    }
}
