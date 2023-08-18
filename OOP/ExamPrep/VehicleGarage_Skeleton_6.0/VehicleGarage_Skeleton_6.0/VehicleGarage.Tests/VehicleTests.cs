using NUnit.Framework;

namespace VehicleGarage.Tests
{
    public class VihicleTests
    {

        [TestCase("VW", "GOLF", "CB7777XA")]
        [TestCase("Toyota", "Rav4", "PB0692BP")]
        public void ConstructorShouldInitializeAllValues(string make, string model, string licensePlate)
        {
            Vehicle vehicle = new Vehicle(make, model, licensePlate);

            Assert.That(make, Is.EqualTo(vehicle.Brand));
            Assert.That(model, Is.EqualTo(vehicle.Model));
            Assert.That(licensePlate, Is.EqualTo(vehicle.LicensePlateNumber));
            Assert.That(false, Is.EqualTo(vehicle.IsDamaged));
            Assert.That(100, Is.EqualTo(vehicle.BatteryLevel));
        }
    }
}