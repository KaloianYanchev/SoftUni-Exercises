namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {

        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new Car("Peugeot", "206", 6, 60);
        }

        [Test]
        public void DefaultConstructorShouldInitializeCarFuelAmountByZero()
        {
            //Assert
            Assert.That(car.FuelAmount == 0);
        }

        [TestCase("Peugeot", "206", 6, 60)]
        public void ConstructorShouldInitializeAsIntented(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            //Arrange and Act
            string expectedMake = make;
            string expectedModel = model;
            double expectedFuelConsumption = fuelConsumption;
            double expectedModelCapacity = fuelCapacity;

            //Assert
            Assert.That(expectedMake == car.Make);
            Assert.That(expectedModel == car.Model);
            Assert.That(expectedFuelConsumption == car.FuelConsumption);
            Assert.That(expectedModelCapacity == car.FuelCapacity);
        }

        [TestCase(null, "206", 6, 60)]
        [TestCase("", "206", 6, 60)]
        public void CarMakeShouldThrowAnExceptionIfNullOrEmpty(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() 
                => new Car(make, model, fuelConsumption, fuelCapacity));

            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }

        [TestCase("peugeot", null, 6, 60)]
        [TestCase("peugeot", "", 6, 60)]
        public void CarModelShouldThrowAnExceptionIfNullOrEmpty(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => new Car(make, model, fuelConsumption, fuelCapacity));

            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }

        [TestCase("peugeot", "206", -10, 60)]
        [TestCase("peugeot", "206", 0, 60)]
        public void CarFuelConsumptionShouldThrowAnExceptionIfEqualOrBelowZero(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => new Car(make, model, fuelConsumption, fuelCapacity));

            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }

        [TestCase("peugeot", "206", 6, -100)]
        [TestCase("peugeot", "206", 6, 0)]
        public void CarFuelCapacityShouldThrowAnExceptionIfEqualOrBelowZero(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => new Car(make, model, fuelConsumption, fuelCapacity));

            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }

        [TestCase(-500)]
        [TestCase(0)]
        public void RefuelMethodShouldThrowAnExceptionIfFuelToRefuelIsBelowOrEqualToZero(double fuel)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => car.Refuel(fuel));

            Assert.AreEqual("Fuel amount cannot be zero or negative!", exception.Message);
        }

        [TestCase(70)]
        [TestCase(100)]
        public void RefuelMethodShouldNotAddMoreLittersThanTheCapacity(double fuel)
        {
            //Arrange
            double expectedResult = car.FuelCapacity;
            //Act
            car.Refuel(fuel);

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        [TestCase(58.00)]
        [TestCase(60.00)]
        [TestCase(59.00)]
        public void RefuelMethodShouldWorkAsIntended(double fuel)
        {
            //Arrange
            double expectedResult = fuel;
            
            //Act
            car.Refuel(fuel);
            double actualResult = car.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(101)]
        [TestCase(100.50)]
        public void DriveMethodShouldThrowAnExceptionIfThereIsNotEnoughFuel(double distance)
        {
            //Act
            car.Refuel(6);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() 
                => car.Drive(distance));

            Assert.AreEqual("You don't have enough fuel to drive!", exception.Message);
        }

        [TestCase(100)]
        public void DriveMethodShouldWorkAsIntended(double distance)
        {
            //Arrange
            double expectedResult = 0;

            //Act
            car.Refuel(6);
            car.Drive(distance);

            //Assert
            Assert.AreEqual(expectedResult, car.FuelAmount);
        }
    }
}