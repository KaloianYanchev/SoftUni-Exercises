namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.Text;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldWorkAsIntended()
        {
            Device device = new Device(100);

            Assert.IsNotNull(device);
            Assert.IsNotNull(device.Applications);
            Assert.AreEqual(100, device.MemoryCapacity);
            Assert.AreEqual(100, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);


        }

        [Test]
        public void TakePhotoShouldReturnFalseIfPictureSizeIsMoreThanMemory()
        {
            Device device = new Device(100);

            Assert.IsFalse(device.TakePhoto(110));
            Assert.AreEqual(100, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
        }
        [TestCase(90)]
        [TestCase(100)]
        public void TakePhotoShouldWorkAsIntended(int memorySize)
        {
            Device device = new Device(100);
            int expectedResult = 100 - memorySize;

            Assert.IsTrue(device.TakePhoto(memorySize));
            Assert.AreEqual(expectedResult, device.AvailableMemory);
            Assert.AreEqual(1, device.Photos);
        }

        [TestCase("Shazam", 200)]
        [TestCase("Player", 110)]
        public void InstallAppShouldThrowAnExceptionIfNotEnoughMemory(string appName, int memorySize)
        {
            Device device = new Device(100);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
                => device.InstallApp(appName, memorySize));

            Assert.AreEqual("Not enough available memory to install the app.",
                exception.Message);
            Assert.AreEqual(100, device.AvailableMemory);
            Assert.AreEqual(0, device.Applications.Count);
        }

        [TestCase("Shazam", 50)]
        [TestCase("Player", 100)]
        public void InstallAppShouldWorkAsIntended(string appName, int memorySize)
        {
            Device device = new Device(100);
            int expectedMemory = 100 - memorySize;
            string expectedResult = $"{appName} is installed successfully. Run application?";

            Assert.AreEqual(expectedResult, device.InstallApp(appName, memorySize));
            Assert.AreEqual(expectedMemory, device.AvailableMemory);
            Assert.AreEqual(1, device.Applications.Count);
        }

        [Test]
        public void InstallAppShouldWorkAsIntended()
        {
            Device device = new Device(100);
            device.TakePhoto(10);
            device.InstallApp("Facebook", 50);

            device.FormatDevice();

            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(0, device.Applications.Count);
            Assert.AreEqual(100, device.AvailableMemory);
        }

        [Test]
        public void GetDeviceStatusShouldWorkAsIntended()
        {
            Device device = new Device(100);
            device.TakePhoto(10);
            device.TakePhoto(10);
            device.InstallApp("Facebook", 20);
            device.InstallApp("Google", 20);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Memory Capacity: {100} MB, Available Memory: {40} MB");
            sb.AppendLine($"Photos Count: {2}");
            sb.AppendLine($"Applications Installed: {"Facebook, Google"}");
            string expectedResult = sb.ToString().TrimEnd();


            Assert.AreEqual(expectedResult , device.GetDeviceStatus());
            Assert.AreEqual(2, device.Photos);
            Assert.AreEqual(2, device.Applications.Count);
            Assert.AreEqual(40, device.AvailableMemory);
        }


    }
}