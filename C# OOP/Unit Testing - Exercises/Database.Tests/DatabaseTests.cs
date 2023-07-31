namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new int[] {1, 2, 3})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ArrayCapacityShouldBeExactlyTheLengthOf16Integers(params int[] data)
        {
            //Arrange and Act
            Database database = new Database(data);

            //Assert
            Assert.That(database.Count, Is.EqualTo(data.Length));
        }

        [TestCase(1, 2)]
        public void CountMethodShouldReturnTheCount(params int[] data)
        {
            //Arrange and Act
            Database database = new Database(data);
            int expectedResult = 2;

            //Assert
            Assert.That(expectedResult, Is.EqualTo(database.Count));
        }


        [TestCase(1, 1)]
        [TestCase(4, 3, 4, 5, 6)]
        [TestCase(10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
        public void AddMethodShouldAddAnIntegerIfCountIsLessThan16(int expectedResult, params int[] data)
        {
            //Arrange
            Database database = new Database();

            //Act
            foreach (int integer in data)
            {
                database.Add(integer);
            }
            
            //Assert
            Assert.That(expectedResult, Is.EqualTo(database.Count));
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16)]

        public void AddMethodShouldAddAnIntegerIfCountIsMoreThan16(params int[] data)
        {
            //Arrange
            Database database = new Database();

            //Act
            foreach (int integer in data)
            {
                database.Add(integer);
            }

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]

        public void RemoveMethodShouldRemoveTheLastElementAtTheLastIndexOfTheArray(params int[] data)
        {
            //Arrange
            Database database = new Database(data);
            int expectedResult = 15;

            //Act
            database.Remove();

            //Assert
            Assert.That(expectedResult == database.Count);
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]

        public void RemoveMethodShouldThrowAnExceptionIfArrayIsEmpty(params int[] data)
        {
            //Arrange
            Database database = new Database(data);

            //Act
            foreach (int integer in data)
            {
                database.Remove();
            }

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]

        public void FetchMethodShouldReturnTheElementsInTheArray(params int[] data)
        {
            //Arrange and Act
            Database database = new Database(data);

            //Assert
            Assert.That(() => database.Fetch(), Is.EqualTo(data));
        }
    }
}
