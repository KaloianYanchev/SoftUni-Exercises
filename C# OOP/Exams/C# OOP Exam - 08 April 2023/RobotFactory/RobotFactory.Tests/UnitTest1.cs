using NUnit.Framework;
using System.Diagnostics;
using System.Reflection;

namespace RobotFactory.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Arm", 1000)]
        [TestCase("Legg", 2000)]

        public void SupplementConstructorShoudWorkAsIntended(string name, int interfaceStandard)
        {
            Supplement supplement = new Supplement(name, interfaceStandard);

            Assert.AreEqual(name, supplement.Name);
            Assert.AreEqual(interfaceStandard, supplement.InterfaceStandard);

        }
        [TestCase("Arm", 1000)]
        [TestCase("Legg", 2000)]

        public void SupplementOverrideToStringShouldWorkAsInteded(string name, int interfaceStandard)
        {
            Supplement supplement = new Supplement(name, interfaceStandard);
            string expectedResult = $"Supplement: {name} IS: {interfaceStandard}";

            Assert.AreEqual(expectedResult, supplement.ToString());
        }

        [TestCase("CE2", 1000, 1000)]
        [TestCase("De3", 2000, 1000)]

        public void RobotConstructorShoudWorkAsIntended(string model, double price, int interfaceStandard)
        {
            Robot robot = new Robot(model, price, interfaceStandard);

            Assert.AreEqual(model, robot.Model);
            Assert.AreEqual(price, robot.Price);
            Assert.AreEqual(interfaceStandard, robot.InterfaceStandard);
            Assert.IsNotNull(robot);
            Assert.IsNotNull(robot.Supplements);
        }

        [TestCase("CE2", 1000, 1000)]
        [TestCase("De3", 2000, 1000)]

        public void RobotToStringShoudWorkAsIntended(string model, double price, int interfaceStandard)
        {
            Robot robot = new Robot(model, price, interfaceStandard);

            string expectedResult = $"Robot model: {model} IS: {interfaceStandard}, Price: {price:f2}";

            Assert.AreEqual(expectedResult, robot.ToString());


        }

        [Test]
        public void FactoryConstructorShoudWorkAsIntended()
        {
            Factory factory = new Factory("Omega", 20);

            Assert.AreEqual("Omega", factory.Name);
            Assert.AreEqual(20, factory.Capacity);
            Assert.IsNotNull(factory);
            Assert.IsNotNull(factory.Robots);
            Assert.IsNotNull(factory.Supplements);
        }

        [TestCase("CE2", 1000, 1000)]
        [TestCase("De3", 2000, 1000)]
        public void FactoryProcureRobotShouldNotAddRobotIfCapacityISFull(string model, double price, int interfaceStandard)
        {
            Factory factory = new Factory("Omega", 1);
            string expectedResult = $"The factory is unable to produce more robots for this production day!";
            factory.ProduceRobot(model, price, interfaceStandard);

            Assert.AreEqual(expectedResult, factory.ProduceRobot(model, price, interfaceStandard));
            Assert.AreEqual(1, factory.Robots.Count);


        }

        [TestCase("CE2", 1000, 1000)] //////
        [TestCase("De3", 2000, 1000)]
        public void FactoryProcureRobotShouldWorkAsIntended(string model, double price, int interfaceStandard)
        {
            Factory factory = new Factory("Omega", 20);
            string expectedResult = $"Produced --> Robot model: {model} IS: {interfaceStandard}, Price: {price:f2}";
            factory.ProduceRobot(model, price, interfaceStandard);
            factory.ProduceRobot(model, price, interfaceStandard);

            
            Assert.AreEqual(expectedResult, factory.ProduceRobot(model, price, interfaceStandard));
            Assert.AreEqual(3, factory.Robots.Count);
        }

        [TestCase("Arm", 1000)] 
        [TestCase("Legg", 2000)]
        public void FactoryProduceSupplementShouldWorkAsIntended(string name, int interfaceStandard)
        {
            Factory factory = new Factory("Omega", 20);
            string expectedResult = $"Supplement: {name} IS: {interfaceStandard}";

            factory.ProduceSupplement(name, interfaceStandard);

            Assert.AreEqual(expectedResult, factory.ProduceSupplement(name, interfaceStandard));
            Assert.AreEqual(2, factory.Supplements.Count);
        }

        [Test]
        public void UpgradeRobotShouldNotAddSupplementIfDifferentStandarts()
        {
            Factory factory = new Factory("Omega", 20);
            Supplement supplement = new Supplement("Arm", 1000);
            Robot robot = new Robot("SD", 1000.23, 2000);

            Assert.IsFalse(factory.UpgradeRobot(robot, supplement));
            Assert.AreEqual(0, robot.Supplements.Count);

        }

        [Test]
        public void UpgradeRobotShouldNotAddSupplementIfContainsTheSameSupplement()
        {
            Factory factory = new Factory("Omega", 20);
            Supplement supplement = new Supplement("Arm", 1000);
            Robot robot = new Robot("SD", 1000.23, 1000);

            factory.UpgradeRobot(robot, supplement);

            Assert.IsFalse(factory.UpgradeRobot(robot, supplement));
            Assert.AreEqual(1, robot.Supplements.Count);
        }

        [Test]
        public void UpgradeRobotShouldWorkAsIntended()
        {
            Factory factory = new Factory("Omega", 20);
            Supplement supplement = new Supplement("Arm", 1000);
            Supplement supplement2 = new Supplement("Legg", 1000);

            Robot robot = new Robot("SD", 1000.23, 1000);

            factory.UpgradeRobot(robot, supplement);

            Assert.IsTrue(factory.UpgradeRobot(robot, supplement2));
            Assert.AreEqual(2, robot.Supplements.Count);

        }

        [Test]
        public void SellRobotShouldWorkAsIntended()
        {
            Factory factory = new Factory("Omega", 20);

            string expectedRobotName = "Tony";
            double expectedRobotPrice = 1200;
            int expectedRobotInterfaceStandard = 1000;


            factory.ProduceRobot("Dim", 1500, 1000);
            factory.ProduceRobot("Megas", 1.50, 1000);
            factory.ProduceRobot("Tony", 1200, 1000);
            factory.ProduceRobot("Evtin", 3.99, 1000);

            Robot actualRobot = factory.SellRobot(1400);


            Assert.AreEqual(expectedRobotName, actualRobot.Model);
            Assert.AreEqual(expectedRobotPrice, actualRobot.Price);
            Assert.AreEqual(expectedRobotInterfaceStandard, actualRobot.InterfaceStandard);
        }

        [Test]
        public void SellRobotShouldReturnNullIfPriceTooHigh()
        {
            Factory factory = new Factory("Omega", 20);

            string expectedRobotName = "Tony";
            double expectedRobotPrice = 1200;
            int expectedRobotInterfaceStandard = 1000;


            factory.ProduceRobot("Dim", 1500, 1000);
            factory.ProduceRobot("Megas", 1.50, 1000);
            factory.ProduceRobot("Tony", 1200, 1000);
            factory.ProduceRobot("Evtin", 3.99, 1000);

            Robot actualRobot = factory.SellRobot(1);

            Assert.IsNull(actualRobot);
        }
    }
}