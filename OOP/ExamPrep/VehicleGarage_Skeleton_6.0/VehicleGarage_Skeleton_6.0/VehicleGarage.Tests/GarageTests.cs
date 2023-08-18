using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGarage.Tests
{
    public class GarageTests
    {
        [TestCase(10)]
        [TestCase(1)]
        public void ConstructorShouldInitializeAllValues(int capacity)
        {
            Garage garage = new Garage(capacity);

            Assert.AreEqual(capacity, garage.Capacity);
            Assert.IsNotNull(garage.Vehicles);
        }
        [TestCase(5, "VW", "Golf", "PB06932BP")]
        [TestCase(5, "Toyota", "Rav4", "A06932BP")]
        public void AddVehicleMethodShouldAddGarageEnoughCapacityAndVehicleDoesNotExist(int capacity, string brand, string model, string licensePlate)
        {
            Garage garage1 = new Garage(capacity);
            Vehicle vehicle = new Vehicle(brand, model, licensePlate);

            var result = garage1.AddVehicle(vehicle);

            Assert.IsTrue(result);
            Assert.Contains(vehicle, garage1.Vehicles);
        }


        [TestCase(5, "Toyota", "Rav4", "A06932BP")]
        public void AddVehicleShouldReturnFalseIfExists(int capacity, string brand, string model, string licensePlate)
        {
            Garage garage1 = new Garage(capacity);
            Vehicle vehicle = new Vehicle(brand, model, licensePlate);


            garage1.AddVehicle(vehicle);
            var result = garage1.AddVehicle(vehicle);


            Assert.IsFalse(result);
        }

        [Test]
        public void AddVehicleShouldReturnFalseIfGarageIsFull()
        {
            Garage garage = new Garage(3);

            Vehicle vehicle = new Vehicle("Toyota", "Rav4", "A06932BP");
            Vehicle vehicle1 = new Vehicle("Toyotaa", "Rav4", "A06932BP");
            Vehicle vehicle2 = new Vehicle("Toyotaaa", "Rav4", "A06932BP");
            Vehicle vehicle3 = new Vehicle("Toyotaaaa", "Rav4", "A06932BP");

            garage.AddVehicle(vehicle);
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);


            var result = garage.AddVehicle(vehicle3);
            var contains = garage.Vehicles.Any(x => x.Brand == vehicle3.Brand
            && x.Model == vehicle3.Model
            && x.LicensePlateNumber == vehicle3.LicensePlateNumber);
            Assert.IsFalse(result);

            Assert.IsFalse(contains);



        }
        [Test]
        public void ChargeVehiclesShouldChargeAllUnderTheGivenValue()
        {
            Garage garage = new Garage(10);

            Vehicle vehicle1 = new Vehicle("Toyotaa", "Rav4", "A06932BP");
            Vehicle vehicle2 = new Vehicle("Toyotaaa", "Raasv4", "as");
            Vehicle vehicle3 = new Vehicle("Toyotaaaa", "Ravadfzx4", "asdsdg");
            Vehicle vehicle4 = new Vehicle("Toyaotaaaa", "Rav4", "dfghbdxfbg");
            Vehicle vehicle5 = new Vehicle("afasd", "Rav4", "asdasd");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);
            garage.AddVehicle(vehicle4);
            garage.AddVehicle(vehicle5);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 90, false);
            garage.DriveVehicle(vehicle2.LicensePlateNumber, 70, false);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 50, false);
            garage.DriveVehicle(vehicle4.LicensePlateNumber, 10, false);

            var charged = garage.ChargeVehicles(50);

            Assert.AreEqual(charged, 3);
            Assert.AreEqual(vehicle1.BatteryLevel, 100);
            Assert.AreEqual(vehicle2.BatteryLevel, 100);
            Assert.AreEqual(vehicle3.BatteryLevel, 100);
            Assert.AreEqual(vehicle4.BatteryLevel, 90);
            Assert.AreEqual(vehicle5.BatteryLevel, 100);



        }
        [Test]
        public void DriveVehicleShouldNotMoveIfBatteryDrainageIsAbove100OrHigher()
        {
            Garage garage = new Garage(10);

            Vehicle vehicle1 = new Vehicle("Toyotaa", "Rav4", "A06932BP");
            Vehicle vehicle2 = new Vehicle("Toyotaaa", "Raasv4", "as");
            Vehicle vehicle3 = new Vehicle("Toyotaaaa", "Ravadfzx4", "asdsdg");
            Vehicle vehicle4 = new Vehicle("Toyaotaaaa", "Rav4", "dfghbdxfbg");
            Vehicle vehicle5 = new Vehicle("afasd", "Rav4", "asdasd");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);
            garage.AddVehicle(vehicle4);
            garage.AddVehicle(vehicle5);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 120, false);

            garage.DriveVehicle(vehicle2.LicensePlateNumber, 50, false);
            garage.DriveVehicle(vehicle2.LicensePlateNumber, 60, false);

            garage.DriveVehicle(vehicle3.LicensePlateNumber, 50, true);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 10, true);

            Assert.AreEqual(100, vehicle1.BatteryLevel);
            Assert.AreEqual(50, vehicle2.BatteryLevel);
            Assert.AreEqual(50, vehicle3.BatteryLevel);

            Assert.IsTrue(vehicle3.IsDamaged);
            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.IsFalse(vehicle2.IsDamaged);
            Assert.IsFalse(vehicle4.IsDamaged);
            Assert.IsFalse(vehicle5.IsDamaged);

        }
        [Test]
        public void RepairVehicle()
        {
            Garage garage = new Garage(10);

            Vehicle vehicle1 = new Vehicle("Toyotaa", "Rav4", "A06932BP");
            Vehicle vehicle2 = new Vehicle("Toyotaaa", "Raasv4", "as");
            Vehicle vehicle3 = new Vehicle("Toyotaaaa", "Ravadfzx4", "asdsdg");
            Vehicle vehicle4 = new Vehicle("Toyaotaaaa", "Rav4", "dfghbdxfbg");
            Vehicle vehicle5 = new Vehicle("afasd", "Rav4", "asdasd");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);
            garage.AddVehicle(vehicle4);
            garage.AddVehicle(vehicle5);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 30, true);

            garage.DriveVehicle(vehicle2.LicensePlateNumber, 50, true);

            garage.DriveVehicle(vehicle3.LicensePlateNumber, 40, true);

            var result = garage.RepairVehicles();
            var allVehiclesRepaired = garage.Vehicles.All(x => !x.IsDamaged);

            Assert.AreEqual($"Vehicles repaired: 3", result);

            Assert.IsTrue(allVehiclesRepaired);
        }
    }
}
